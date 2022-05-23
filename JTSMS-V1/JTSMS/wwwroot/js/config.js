$(document).ready(function () {
    $('body').off('click', '#btn-add').on('click', '#btn-add', Add);
   

    user = document.getElementById('userinfo').getAttribute('data-user');
    name = document.getElementById('userinfo').getAttribute('data-display-name');
    email = document.getElementById('userinfo').getAttribute('data-email');


    function Add() {
        var model = new Object();
        model.CustId = parseInt( $('#txt-customer').val());
        model.ProcessStep = $('#txt-processstep').val();
        model.RouteStep = $('#txt-routestep').val();
        model.TesterName = $('#txt-testername').val();
        model.TesterPcName = $('#txt-testerpcname').val();
        model.EquipmentId = parseInt($('#txt-equipmentid').val());
        model.TestTime = parseInt($('#txt-testtime').val());
        model.CreatedBy = user;
        model.CreatedName = name;
        model.CreatedEmail = email;
        debugger
        $.ajax({
            type: 'post',
            url: '/config/Insert',
            data: JSON.stringify(model),
            contentType: 'application/json;charset=utf-8',
            success: function (response) {
                results = response.results
                if (results.statusCode == 200) {
                    bootbox.alert(results.message, function () { location.reload() })
                }
                else {
                    bootbox.alert(results.message)
                }
            }
        })
    }
})