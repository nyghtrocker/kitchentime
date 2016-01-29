
        var viewModel =
{
    Products: ko.observableArray([]),
}

$(document).ready(function () {
    $.ajax({
        url: "http://localhost:56410/api/getProducts",
        contentType: "text/json",
        type: "GET",
        success: function (data) {
            $.each(data, function (index) {
                viewModel.Products.push(ToKnockOutObservable(data[index]));
            });
            ko.applyBindings(viewModel);
        },
        error: function (data) {
            alert("error occured");
        }
    });
    function ToKnockOutObservable(Products) {
        return {
            ProductName: ko.observable(Products.ProductName),
            ProductShortDescription: ko.observable(Products.ProductShortDescription),
            ProductDescription: ko.observable(Products.ProductDescription),
            ProductImage: ko.observable(Products.ProductImage),
            ProductUrl: ko.observable(Products.ProductUrl),
        };
    }

    
});
