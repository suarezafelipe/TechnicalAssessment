var ProductController = function (productService) {

    // Creates the product in memory or in database
    $("#CreateProductButton").click(function () {
        var serializedForm = $("#CreateProductForm").serialize();
        productService.createProduct($("#StorageMethod").val(), serializedForm);
    });

}(ProductService);


