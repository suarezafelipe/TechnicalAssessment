var ProductsController = function () {

    // Gets the last value of the storage method ("Database" if it's the first time)
    var storage;

    if (localStorage.getItem("storageMethod")) {
        storage = localStorage.getItem("storageMethod");
    } else {
        storage = "Database";
    };
    
    // Updates the navbar on first load
    updateNavbar(storage);

    // Updates the navbar on every click
    $("#ChangeStorage").click(function () {
        storage = (storage === "Database") ? "Memory" : "Database";
        updateNavbar(storage);
        localStorage.setItem("storageMethod", storage);
    });

    // Updates the navbar color and the text
    function updateNavbar(storageString) {
        $(".navbar-brand").text("You are currently in: " + storageString + " Storage.");
        
        if (storageString === "Database") {
            $("#AppNavbar").removeClass("navbar-inverse").addClass("navbar-default");
        } else if (storageString === "Memory") {
            $("#AppNavbar").removeClass("navbar-default").addClass("navbar-inverse");
        }
    }

}();


