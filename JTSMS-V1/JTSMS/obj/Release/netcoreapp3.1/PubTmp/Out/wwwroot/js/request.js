$(document).ready(function () {
    $('body').off('click', '#btn-search').on('click', '#btn-search', Search);
    $('body').off('click', '#btn-add').on('click', '#btn-add', Add);
    $('body').off('click', '#btn-delete').on('click', '#btn-delete', Delete);
    $('body').off('click', '#btn-submit').on('click', '#btn-submit', Submit);
    $('body').off('click', '#btn-approve').on('click', '#btn-approve', Approve);
    $('body').off('click', '#btn-reject').on('click', '#btn-reject', Reject);
    $('body').off('click', '#btn-close').on('click', '#btn-close', Close);

    user = document.getElementById('userinfo').getAttribute('data-user');
    name = document.getElementById('userinfo').getAttribute('data-display-name');
    email = document.getElementById('userinfo').getAttribute('data-email');


    function Approve() {
        var model = new Object();

        var model = new Object();
        model.ReqId = parseInt($(this).attr('data-reqid'));
        model.ScriptId = $(this).attr('txt-scriptid');
        model.RouteId = parseInt($(this).attr('data-routeid'));
        model.Remark = $('#txt-remark').val();
        model.UpdatedBy = user
        model.UpdatedName = name
        model.UpdatedEmail = email

        $.ajax({
            type: 'post',
            url: '/request/Request_approve',
            data: JSON.stringify(model),
            cache: false,
            dataType: 'json',
            contentType: 'application/json;charset=utf-8',
            success: function (response) {
                var statusCode = response.results.statusCode;
                var message = response.results.message;

                if (statusCode == 200) {
                    bootbox.alert(message, function () { location.reload() });
                }

                else {
                    bootbox.alert(message);
                }
            },
            error: function (e) {
                bootbox.alert(e.responseText);
            }
        })

    }

    function Reject() {
        var model = new Object();

        var model = new Object();
        model.ReqId = parseInt($(this).attr('data-reqid'));
        model.ScriptId = $(this).attr('txt-scriptid');
        model.RouteId = parseInt($(this).attr('data-routeid'));
        model.Remark = $('#txt-remark').val();
        model.UpdatedBy = user
        model.UpdatedName = name
        model.UpdatedEmail = email

        $.ajax({
            type: 'post',
            url: '/request/Request_reject',
            data: JSON.stringify(model),
            cache: false,
            dataType: 'json',
            contentType: 'application/json;charset=utf-8',
            success: function (response) {
                var statusCode = response.results.statusCode;
                var message = response.results.message;

                if (statusCode == 200) {
                    bootbox.alert(message, function () { location.reload() });
                }

                else {
                    bootbox.alert(message);
                }
            },
            error: function (e) {
                bootbox.alert(e.responseText);
            }
        })

    }

    function Add() {

        var model = new Object();
        model.CustId = parseInt($("#txt-customer").val());
        model.StationId = parseInt($("#txt-station").val());
        model.RouteId = parseInt($("#txt-route").val());
        model.TypeId = parseInt($("#txt-type").val());
        model.PlatformId = parseInt($("#txt-platform").val());
        model.AssemblyNumber = $('#txt-assy').val() ? $('#txt-assy').val() : null;
        model.AssemblyRevision = $('#txt-rev').val() ? $('#txt-rev').val() : null;
        model.ScriptId = $('#txt-route').val() ? $('#txt-route').val() : null;
        model.Description = $('#txt-desc').val() ? $('#txt-desc').val() : null;
        model.CreatedBy = user
        model.CreatedName = name
        model.CreatedEmail = email

        $.ajax({
            type: 'post',
            url: '/request/Request_Add',
            data: JSON.stringify(model),
            contentType: 'application/json;charset=utf-8',
            success: function (response) {

                var statusCode = response.results.statusCode;
                var message = response.results.message;

                if (statusCode == 200) {
                    bootbox.alert(message, function () { Load(model); });
                }
                else if (statusCode == 409) {
                    bootbox.alert(message);
                }
                else {
                    bootbox.alert(message);
                }
            }
        })
    }


    function Delete() {

        var model = new Object();
        model.CustId = parseInt($("#txt-customer").val());
        model.StationId = parseInt($("#txt-station").val());
        model.TypeId = parseInt($("#txt-type").val());
        model.PlatformId = parseInt($("#txt-platform").val());
        model.AssemblyNumber = $('#txt-assy').val() ? $('#txt-assy').val() : null;
        model.AssemblyRevision = $('#txt-rev').val() ? $('#txt-rev').val() : null;
        model.ReqId = parseInt($(this).attr('data-reqid'));
        model.UpdatedBy = user;
        model.UpdatedName = name;
        model.UpdatedEmail = email;
        debugger
        $.ajax({
            type: 'post',
            url: '/request/RequestDetail_delete',
            data: JSON.stringify(model),
            contentType: 'application/json;charset=utf-8',
            success: function (response) {

                var statusCode = response.results.statusCode;
                var message = response.results.message;

                if (statusCode == 200) {
                    bootbox.alert(message, function () { Load(model); });
                }
                else if (statusCode == 409) {
                    bootbox.alert(message);
                }
                else {
                    bootbox.alert(message);
                }
            }
        })
    }

    function Submit() {

        var getDate = new Date();
        var date = getDate.getFullYear().toString() + (getDate.getMonth() + 1) + getDate.getDate() + getDate.getHours() + getDate.getMinutes() + getDate.getSeconds() + getDate.getMilliseconds();

        //var selectedFile = document.getElementById('txt-file2').files[0];

        var script = $('#txt-script')[0].files[0]; // get the File obect
        var arr_script = script.name.split('.')
        var len_script = arr_script.length
        var extension = arr_script[len_script - 1]
        name_script = arr_script.slice(0, len_script - 1).join('.');
        name_script += '_' + date + '.' + extension;


        var encripted = $('#txt-encripted')[0].files[0]; // get the File obect
        var arr_encripted = encripted.name.split('.')
        var len_encripted = arr_encripted.length
        var extension = arr_encripted[len_encripted - 1]
        name_encripted = arr_encripted.slice(0, len_encripted - 1).join('.');
        name_encripted += '_' + date + '.' + extension;


        var model = new Object();
        model.ReqId = parseInt($(this).attr('data-reid'));
        model.TypeId = parseInt($(this).attr('data-typeid'));
        model.ScriptName = $("#txt-scriptname").val();
        model.ScriptRev = $('#txt-scriptrev').val();
        model.Firmware = $('#txt-firmware').val();
        model.FirmwareRevision = $('#txt-firmwarerev').val();
        model.Description = $('#txt-description').val();
        model.UpdatedBy = user
        model.UpdatedName = name
        model.UpdatedEmail = email
        model.ScriptFileName = name_script
        model.EncriptedFileName = name_encripted
        model.FileHash = $('#txt-encripted').attr('data-hash-encripted').toUpperCase();
        debugger
        $.ajax({
            type: 'post',
            url: '/request/Request_submit',
            dataType: 'json',
            data: JSON.stringify(model),
            contentType: 'application/json;charset=uft-8',
            success: function (response) {
                var statusCode = response.results.statusCode;
                var message = response.results.message;

                if (statusCode == 200) {
                    bootbox.alert(message, function () { location.reload() });
                }
                else if (statusCode == 409) {
                    bootbox.alert(message);
                }
                else {
                    bootbox.alert(message);
                }
            }
        })


        uploadFile(script, name_script);
        uploadFile(encripted, name_encripted);
    }


    function uploadFile(_file, _fileName) {
        var form_data = new FormData();
        form_data.append("file", _file);
        form_data.append("fileName", _fileName);
        debugger
        $.ajax({
            type: 'post',
            url: '/Request/UploadFile',
            data: form_data,
            contentType: false,
            //dataType: 'json',
            processData: false,
            cache: false,
            success: function (data) {
                console.log(data)
            },
            error: function (err) {
                alert(err.statusText);
            }
        })
    }

    function Close() {
        var model = new Object();
        model.ReqId = parseInt($(this).attr('data-reqid'));
        //model.TypeId = parseInt($(this).attr('data-typeid'));
        //model.ScriptName = $("#txt-scriptname").val();
        //model.ScriptRev = $('#txt-scriptrev').val();
        //model.Firmware = $('#txt-firmware').val();
        //model.FirmwareRevision = $('#txt-firmwarerev').val();
        model.Remark = $('#txt-remark').val();
        model.UpdatedBy = user
        model.UpdatedName = name
        model.UpdatedEmail = email

        debugger
        $.ajax({
            type: 'post',
            url: '/request/Request_close_deviation',
            dataType: 'json',
            data: JSON.stringify(model),
            contentType: 'application/json;charset=uft-8',
            success: function (response) {
                var statusCode = response.results.statusCode;
                var message = response.results.message;

                if (statusCode == 200) {
                    bootbox.alert(message, function () { location.reload() });
                }
                else if (statusCode == 409) {
                    bootbox.alert(message, function () { location.reload() });
                }
                else {
                    bootbox.alert(message);
                }
            }
        })
    }

    function Search() {
        $('#tbl-content').html('');
        var model = new Object();

        model.CustId = parseInt($("#txt-customer-search").val());
        model.StationId = parseInt($("#txt-station-search").val());
        model.AssemblyNumber = $('#txt-assy-search').val() ? $('#txt-assy-search').val() : null;
        model.AssemblyRevision = $('#txt-rev-search').val() ? $('#txt-rev-search').val() : null;
        model.ScriptId = $('#txt-scriptid-search').val() ? $('#txt-scriptid-search').val() : null;

        Load(model)
        //$.ajax({
        //    type: 'post',
        //    url: '/request/RequestDetail_get',
        //    //dataType: 'json',
        //    data: JSON.stringify(model),
        //    contentType: 'application/json;charset=uft-8',
        //    success: function (response) {
        //        $('#tbl-content').html(response);
        //    }
        //})
    }

    function Load(model) {
        debugger
        $.ajax({
            type: 'post',
            url: '/request/RequestDetail_get',
            //dataType: 'json',
            cache:false,
            data: JSON.stringify(model),
            contentType: 'application/json;charset=uft-8',
            success: function (response) {
                $('#tbl-content').html(response);
            }
        })
    }


})