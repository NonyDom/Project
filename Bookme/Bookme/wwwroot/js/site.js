function SaveCategoryDetails() {
    debugger
    let name = $("#name").val();

    if (name != "") {
        $.ajax({
            type: 'POST',
            url: '/SuperAdmin/CreateCategory',
            dataType: 'json',
            data:
            {
                categoryName: name,
            },
            success: function (result) {
                debugger
                if (!result.isError) {
                    var url = '/SuperAdmin/Category'; 
                    successAlertWithRedirect(result.msg, url);
                }
                else {
                    errorAlert(result.msg);
                }
            },
            error: function (ex) {
                errorAlert(result.msg);
            }
        });
    } else {
       
        errorAlert("Invalid, Please fill the form correctly.");
    }
}
function getCategoryDetails(id) {
    $.ajax({
        type: 'GET',
        url: "/SuperAdmin/GetCategoryToEdit",
        data: { categoryId: id },
        success: function (data) {
            $('#categoryId').val(data.data.id);
            $('#categoryName').val(data.data.name);
            $('#editCategory').modal('show');
        }
    });
}
function EditCategoryDetails()
{
    debugger
    let data = {}
    data.id = $("#categoryId").val();
    data.name = $("#categoryName").val();
    var details = JSON.stringify(data);
    if (data.name != "") {
        $.ajax({
            type: 'POST',
            url: '/SuperAdmin/UpdateCategory',
            dataType: 'json',
            data:
            {
                categoryName: details,
            },
            success: function (result) {
                debugger
                if (!result.isError) {
                    var url = '/SuperAdmin/Category';
                    successAlertWithRedirect(result.msg);
                }
                else {
                    errorAlert(result.msg);
                }
            },
            error: function (ex) {
                errorAlert(result.msg);
            }
        });
    } else {
        errorAlert("Invalid, Please fill the form correctly.");
    }
}

function deleteCategoryDetails() {
    debugger
    id = $("#deleteCategoryId").val();
    $.ajax({
        type: 'POST',
        url: '/SuperAdmin/DeleteCategory',
        dataType: 'json',
        data:
        {
            id: id,
        },
        success: function (result) {
            debugger
            if (!result.isError) {
                var url = '/SuperAdmin/Category';
                successAlertWithRedirect(result.msg, url);
            }
            else {
                errorAlert(result.msg);
            }
        },
        error: function (ex) {
            errorAlert(result.msg);
        }
    });
    
}
function categoryToDelete(categoryId){
    debugger
    $("#deleteCategoryId").val(categoryId);
}