﻿$(document).ready(function () {
    $('body').off('click', '#btn-search').on('click', '#btn-search', Search);
    $('body').off('click', '#btn-add').on('click', '#btn-add', Add);
    $('body').off('click', '#btn-delete').on('click', '#btn-delete', Delete);
    $('body').off('click', '#btn-submit').on('click', '#btn-submit', Submit);
    $('body').off('click', '#btn-approve').on('click', '#btn-approve', Approve);

    $('body').off('click', '#btn-reject').on('click', '#btn-reject', Reject);
    $('body').off('click', '#btn-close').on('click', '#btn-close', Close);
    $('body').off('click', '#btn-close-approval').on('click', '#btn-close-approval', Close_Approval);

    $('body').off('click', '#btn-search-input').on('click', '#btn-search-input', Search1);
    $('body').off('click', '#btn-select').on('click', '#btn-select', Select);

    user = document.getElementById('userinfo').getAttribute('data-user');
    name = document.getElementById('userinfo').getAttribute('data-display-name');
    email = document.getElementById('userinfo').getAttribute('data-email');

    function Search1() {
        $('#tbl-result').html('');

        _number = $('#txt-search-input').val();
        debugger
        $.ajax({
            type: 'post',
            url: '/request/Search_Number',
            data: { number: _number },
            success: function (response) {
                debugger
                if (response) {
                    $('#tbl-result').html(response);
                }
                else {
                    bootbox.alert("Number is not found");
                }
            }
        })
    }
    function Select() {
        _number = $(this).attr('data-number');
        _rev = $(this).attr('data-rev');
        id = $(this).attr('data-id');
        $('#txt-assy').val(_number);
        $('#txt-rev').val(_rev);
        //$('#txt-equipmentid').attr('data-id', id);
        $('#txt-search-input').val(_number);
        $('#tbl-result').html('');
        $('#modal-search').modal('hide');
        debugger

    }


    function Approve() {
        var model = new Object();

        var model = new Object();
        model.ReqId = parseInt($(this).attr('data-reqid'));
        model.ScriptId = $('#txt-scriptid').val();
        model.RouteId = parseInt($(this).attr('data-routeid'));
        model.Remark = $('#txt-remark').val();
        model.Action = "Approve";
        model.UpdatedBy = user
        model.UpdatedName = name
        model.UpdatedEmail = email

        $.ajax({
            type: 'post',
            url: '/request/Request_update',
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
        model.Action = "Reject";
        model.UpdatedBy = user
        model.UpdatedName = name
        model.UpdatedEmail = email

        $.ajax({
            type: 'post',
            url: '/request/Request_update',
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

    //$('#frm-add-1').validate({
    //    rules: {
    //        customer: { required: true, },
    //        station: { required: true, },
    //        route: { required: true, },
    //        assy: { required: true, },
    //        rev: { required: true, },
    //        type: { required: true, },
    //        platform: { required: true, },
    //    },
    //    messages: {
    //        station: { required: "dasda",},
    //    }
    //})

    function Add() {
        //if ($('#frm-add-1').valid()) {

        customer = parseInt($("#txt-customer").val());
        station = parseInt($("#txt-station").val());
        route = $("#txt-route").val();
        type = parseInt($("#txt-type").val());
        platform = parseInt($("#txt-platform").val());
        assy = $('#txt-assy').val() ? $('#txt-assy').val() : null;
        rev = $('#txt-rev').val() ? $('#txt-rev').val() : null;
        if (customer && station && route && type && platform && assy && rev) {
            var model = new Object();
            model.CustId = customer;
            model.StationId = station;
            model.RouteStep = route;
            model.TypeId = type;
            model.PlatformId = platform;
            model.AssemblyNumber = assy;
            model.AssemblyRevision = rev;
            //model.ScriptId = null;
            model.Description = $('#txt-description').val() ? $('#txt-description').val() : null;
            model.CreatedBy = user
            model.CreatedName = name
            model.CreatedEmail = email
            debugger
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
        else {
            bootbox.alert("Please input all required info");
        }
    }

    function Delete() {

        var model = new Object();
        //model.CustId = parseInt($("#txt-customer-search").val());
        //model.StationId = parseInt($("#txt-station-search").val());
        //model.TypeId = parseInt($("#txt-type").val());
        //model.PlatformId = parseInt($("#txt-platform").val());
        //model.AssemblyNumber = $('#txt-assy').val() ? $('#txt-assy').val() : null;
        //model.AssemblyRevision = $('#txt-rev').val() ? $('#txt-rev').val() : null;
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

    $('#frm-submit').validate({
        rules: {
            scriptname: { required: true, },
            scriptrev: { required: true, },
            firmware: { required: true, },
            firmwarerev: { required: true, },
            description: { required: true, },
            script: { required: true, },
            encrypted: { required: true, },
            PCNorDevNumber: { required: true, },
            changeDetail: { required: true, },
        },
        //messages: {
        //    scriptname: { required: "This field is required", },
        //    scriptrev: { required: "This field is required", },
        //    firmware: { required: "This field is required", },
        //    firmwarerev: { required: "This field is required", },
        //    //description: { required: "This field is required", },
        //    script: { required: "This field is required", },
        //    //encrypted: { required: "This field is required", },
        //}
    })
    function Submit() {
        if ($('#frm-submit').valid()) {


            var getDate = new Date();
            var date = getDate.getFullYear().toString() + (getDate.getMonth() + 1) + getDate.getDate() + getDate.getHours() + getDate.getMinutes() + getDate.getSeconds() + getDate.getMilliseconds();

            //var selectedFile = document.getElementById('txt-file2').files[0];

            var script = $('#txt-script')[0].files[0]; // get the File obect
            var arr_script = script.name.split('.')
            var len_script = arr_script.length
            var extension = arr_script[len_script - 1]
            name_script = arr_script.slice(0, len_script - 1).join('.');
            name_script += '_' + date + '.' + extension;

            var encrypted = $('#txt-encrypted')[0].files[0]; // get the File obect
            var arr_encrypted = encrypted.name.split('.')
            var len_encrypted = arr_encrypted.length
            var extension = arr_encrypted[len_encrypted - 1]
            name_encrypted = arr_encrypted.slice(0, len_encrypted - 1).join('.');
            name_encrypted += '_' + date + '.' + extension;

            var model = new Object();
            model.ReqId = parseInt($(this).attr('data-reid'));
            model.TypeId = parseInt($(this).attr('data-typeid'));
            model.ScriptName = $("#txt-scriptname").val();
            model.ScriptRev = $('#txt-scriptrev').val();
            model.PCNorDevNumber = $('#txt-PCNorDevNumber').val();
            model.ChangeDetail = $('#txt-changeDetail').val();
            model.Firmware = $('#txt-firmware').val();
            model.FirmwareRevision = $('#txt-firmwarerev').val();
            model.Description = $('#txt-description').val();
            model.UpdatedBy = user
            model.UpdatedName = name
            model.UpdatedEmail = email
            model.ScriptFileName = name_script
            model.EncryptedFileName = name_encrypted
            model.FileHash = $('#txt-encrypted').attr('data-hash-encrypted').toUpperCase();
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
            uploadFile(encrypted, name_encrypted);
        }
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
        model.ScriptId = $('#txt-scriptid').val();

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
    function Close_Approval() {
        var model = new Object();
        model.ReqId = parseInt($(this).attr('data-reqid'));
        model.ScriptId = $('#txt-scriptid').val();
        model.Remark = $('#txt-remark-deviation').val();
        model.UpdatedBy = user
        model.UpdatedName = name
        model.UpdatedEmail = email

        debugger
        $.ajax({
            type: 'post',
            url: '/request/Request_close',
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
            cache: false,
            data: JSON.stringify(model),
            contentType: 'application/json;charset=uft-8',
            success: function (response) {
                $('#tbl-content').html(response);
            }
        })
    }
  
})