var ListController = function () {
    var memory;
    if (localStorage.getItem("productsInMemory")) {
        memory = JSON.parse(localStorage.getItem("productsInMemory"));
    } else {
        memory = { products: [] };
    }

    var html = "<table class='table table-striped'>" +
        "<tr> <th>Product Number</th> <th>Title</th> <th>Price</th> </tr>";

    for (var i = 0; i < memory.products.length; i++) {
        html += "<tr> <td>" +
            memory.products[i].productNumber.replace("+", " ") +
            "</td> <td>" +
            memory.products[i].name.replace("+"," ") +
            "</td> <td>" +
            memory.products[i].price +
            "</td> </tr>";
    }
    html += "</table>";

    $("#ListProducts").append(html);

    $("#ClearMemory").click(function() {
        localStorage.clear();
        localStorage.setItem("storageMethod", "Memory");
        location.reload(true);
    });
}();
