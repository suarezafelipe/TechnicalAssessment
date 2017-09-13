var ProductService = function () {
    var createProduct = function(where, data) {
        if (where === "Database") {
            $.ajax({
                type: "POST",
                url: getUrlCreateProduct(),
                data: data,
                success: function(response) {
                    alert(response.Message);
                    cleanFields();
                },
                error: function() {
                    alert("A server error ocurred. Please contact support");
                }
        });

        } else if (where === "Memory") {

            var memory;

            // Brings the products that were in memory, or creates an empty array
            if (localStorage.getItem("productsInMemory")) {
                memory = JSON.parse(localStorage.getItem("productsInMemory"));
            } else {
                memory = { products: [] };
            }
            var product = parseToJson(data);

            if (product.Name && product.Price && product.ProductNumber) {
                memory.products.push({
                    name: product.Name,
                    price: product.Price,
                    productNumber: product.ProductNumber
                });

                localStorage.setItem("productsInMemory", JSON.stringify(memory));
            }
            
        }
    };
    
    var parseToJson = function (url) {
        var hash;
        var myJson = {};
        var hashes = url.slice(url.indexOf('?') + 1).split('&');
        for (var i = 0; i < hashes.length; i++) {
            hash = hashes[i].split('=');
            myJson[hash[0]] = hash[1];
        }
        return myJson;
    }


    return {
        createProduct: createProduct
    }
}();