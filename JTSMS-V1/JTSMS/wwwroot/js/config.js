$(document).ready(function () {
    $('body').off('click', '#btn-add').on('click', '#btn-add', Add);


    user = document.getElementById('userinfo').getAttribute('data-user');
    name = document.getElementById('userinfo').getAttribute('data-display-name');
    email = document.getElementById('userinfo').getAttribute('data-email');
    $('#frm-add').validate({
        rules: {

            customer: { required: true, },
            processstep: { required: true, },
            routestep: { required: true, },
            testername: { required: true, },
            testerpcname: { required: true, },
            equipmentid: { required: true,},
            platform: { required: true, },
            testtime: { required: true, number: true, },          
        },
        messages: {
            customer: { required: "This field is required", },
            processstep: { required: "This field is required", },
            routestep: { required: "This field is required", },
            testername: { required: "This field is required", },
            testerpcname: { required: "This field is required", },
            //equipmentid: { required: "This field is required", },
            platform: { required: "This field is required", },
            testtime: { required: "This field is required", },            
        }
    });

    function Add() {
        if ($('#frm-add').valid()) {
            var model = new Object();
            model.CustId = parseInt($('#txt-customer').val());
            model.ProcessStep = $('#txt-processstep').val();
            model.RouteStep = $('#txt-routestep').val();
            model.TesterName = $('#txt-testername').val();
            model.TesterPcName = $('#txt-testerpcname').val();
            model.EquipmentId = parseInt($('#txt-equipmentid').val());
            model.PlatformId = parseInt($('#txt-platform').val());
            model.TestTime = parseInt($('#txt-testtime').val());
            model.Trigger = $('#txt-trigger').attr('checked') ? 1 : 0;
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
    }
})