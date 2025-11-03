try {

    $("#sid").change(function () {

        sidVal = $(this).val();
        if (sidVal && sidVal > 0) {

            $.ajax({

                method: "GET",
                url: "?handler=Districts",
                data: {
                    sid: sidVal
                },
                success: function (result) {
                    $("#did").empty();
                    $("#did").append(`<option value=""> -Select District- </option>`);
                    $.each(result, function (i, item) {                        
                        $("#did").append(`<option value="${item.id}">${item.text} </option>`);
                    });
                },
                error: function (xhr, status, error) {
                    console.log("Status", + xhr.status);
                    console.log("Error:", + error);
                }
            });
        }
        else {
            $("#did").empty();
            $("#did").append(`<option value="">-Select District- </option>`)
            alert("Select valid state");
        }
    });

}
catch (e) {
    console.log(e.message);
}