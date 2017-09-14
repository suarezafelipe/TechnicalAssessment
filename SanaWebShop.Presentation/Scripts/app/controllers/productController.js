var ProductController = function (productService) {

    var init = function () {
        
    };

    // Creates the product in memory or in database
    $("#CreateProductButton").click(function () {
        var serializedForm = $("#CreateProductForm").serialize();
        productService.createProduct($("#StorageMethod").val(), serializedForm);
    });

    return {
        init: init
    }

}(ProductService);


