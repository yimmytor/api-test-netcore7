(() => 
{
    function main(){
        document.addEventListener('DOMContentLoaded', loadCategorySelect)
        document.querySelector('#slcCategory').addEventListener('change', loadProducts)
    }   

    async function loadCategorySelect()
    {
        let url = 'https://localhost:7085/api/categories/all';
        let categoriesList;
        let slcCategory = document.querySelector('#slcCategory');        
    
        showHideLoader(true);
        hideMessage();

        try {            
            while (slcCategory.firstChild)
            {
                slcCategory.removeChild(slcCategory.firstChild);
            }

            categoriesList = await fetch(url);
            categoriesList = await categoriesList.json();

            sortCategories(categoriesList);

            categoriesList.forEach(category => {
                let option = document.createElement('option');

                option.value = category.id;
                option.textContent = category.name;

                slcCategory.appendChild(option);
            });
        
            loadProducts();
        } catch (error) {
            showMessage('error', 'Failed to retrieve categories information...');
        }        

        showHideLoader(false);
    }

    function loadProducts()
    {
        let products = document.querySelector('#products');
        let slcCategory = document.querySelector('#slcCategory');
        let currentCategory = slcCategory.options[slcCategory.selectedIndex].value;

        hideMessage();

        while (products.firstChild)
        {
            products.removeChild(products.firstChild);
        }

        loadProductsByCategory(currentCategory);
    }

    async function loadProductsByCategory(idCategory)
    {
        let url = 'https://localhost:7085/api/products/category/' + idCategory;
        let products = document.querySelector('#products');
        let productsList;

        showHideLoader(true);

        try
        {
            productsList = await fetch(url);
            productsList = await productsList.json();

            if (productsList.length > 0)
            {
                productsList.forEach(product => {
                    let productDiv = document.createElement('div');
                    let productName = document.createElement('h2');
                    let productSku = document.createElement('p');
                    let productInfo = document.createElement('div');
                    let productDescription = document.createElement('p');
                    let productTags = document.createElement('p');

                    productName.textContent = product.name;
                    productName.classList.add('product-name');

                    productSku.textContent = product.sku;
                    productSku.classList.add('product-sku');

                    productDescription.textContent = product.description;
                    productDescription.classList.add('product-description');

                    product.tags.forEach(tag => {
                        productTags.textContent += productTags.textContent.length > 0 ? ', ' + tag : tag; 
                    });

                    productTags.classList.add('product-tags');

                    productInfo.classList.add('product-info');

                    productInfo.appendChild(productDescription);
                    productInfo.appendChild(productTags);

                    productDiv.classList.add('product-card');
                    
                    productDiv.appendChild(productName);
                    productDiv.appendChild(productSku);
                    productDiv.appendChild(productInfo);

                    products.appendChild(productDiv);
                });
            }
            else
            {
                showMessage('message', 'No products found in this category...');
            }
        } catch (error) {
            showMessage('error', 'Failed to retrieve products information...');
        }

        showHideLoader(false);
    }

    function sortCategories(categories)
    {
        if (categories.length > 0)
        {
            categories.sort((a,b)=>{
                if (a.name.toLowerCase() < b.name.toLowerCase())
                {
                    return -1;
                }

                if (a.name.toLowerCase() < b.name.toLowerCase())
                {
                    return 1;
                }

                return 0;
            })
        }
    }

    function hideMessage()
    {
        let messageBox = document.querySelector('#info-products');

        if (!messageBox.classList.contains('hidden'))
        {
            messageBox.classList.add('hidden');
        }
    }

    function showMessage(type, message)
    {
        let messageBox = document.querySelector('#info-products');
        
        messageBox.classList.remove('hidden');
        messageBox.classList.remove('error');

        if (type == 'error')
        {
            messageBox.classList.add('error');
        }

        messageBox.textContent = message;
    }

    function showHideLoader(show)
    {
        if (show)
        {
            document.querySelector("#loader").classList.remove('hidden');
        }
        else
        {
            document.querySelector("#loader").classList.add('hidden');
        }
    }

    main();
}
)();