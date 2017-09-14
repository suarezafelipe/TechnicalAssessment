$(function () {
    var storage; // In this variable we save the current method of storage (Database or Memory)

    // Gets the last value of the storage method ("Database" if it's the first time)
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

    // Function to update the navbar
    function updateNavbar(storageString) {
        $(".navbar-brand").text("You are currently in: " + storageString + " Storage.");
        if (storageString === "Database") {
            $("#AppNavbar").removeClass("navbar-inverse").addClass("navbar-default");
        } else if (storageString === "Memory") {
            $("#AppNavbar").removeClass("navbar-default").addClass("navbar-inverse");
        }

        $("#StorageMethod").val(storage); // The ViewBag must be updated here so that it updates both on load and on update
    }


    $("#ListProductsMenu").click(function() {
        if (storage === "Memory") {
            window.location = getUrlListProductMemory();
        } else {
            window.location = getUrlListProduct();
        }

    });

});


