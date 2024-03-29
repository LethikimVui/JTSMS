﻿$(document).ready(function () {
    $('body').off('click', '#btn-detail').on('click', '#btn-detail', Load);
    $('body').off('click', '#btn-search-input').on('click', '#btn-search-input', SearchName);
    $('body').off('click', '#btn-add').on('click', '#btn-add', Add);
    $('body').off('click', '#btn-delete').on('click', '#btn-delete', Delete);


    user = document.getElementById('userinfo').getAttribute('data-user');
    name = document.getElementById('userinfo').getAttribute('data-display-name');
    email = document.getElementById('userinfo').getAttribute('data-email');

    var routename = "";
    var routeId = 0
    function Load() {
        routeId = parseInt($(this).attr('data-id'))
        routename = $(this).attr('data-routename');
        Detail(routeId)
    }
    function Detail(_routeId) {
        debugger
        $.ajax({
            type: 'get',
            url: '/Admin/Master_Approval_get_by_routeId',
            //dataType: 'json',
            data: { routeId: _routeId },
            contentType: 'application/json;charset=uft-8',
            success: function (response) {
                document.getElementById("detail").setAttribute("style", "display:inline; min-height: auto !important;");
                debugger
                $('#lbl-title').html(routename);
                $('#tbl-detail').html(response);
            }
        })
    }
    function SearchName() {
        _ntid = $('#txt-search-input').val();
        debugger
        $.ajax({
            type: 'post',
            url: '/admin/GetDisplayNameFromSamAccountName',
            data: { samAccountName: _ntid },
            success: function (response) {
                debugger
                if (response) {
                    $('#txt-userName').text(response);
                    $('#txt-Ntlogin').val(_ntid);
                    $('#modal-search').modal('hide');
                }
                else {
                    bootbox.alert("User is not found");
                }
            }
        })

    }
    function Add() {
        var model = new Object();
        model.Ntlogin = $('#txt-Ntlogin').val();
        model.RouteId = routeId // parseInt($(this).attr('data-routeid'));
        model.PlantId = 1 // parseInt(document.getElementById("txt-wc").value);
        model.CustId = parseInt(document.getElementById("txt-custid").value);
        model.CreatedBy = user;
        debugger
        $.ajax({
            type: 'post',
            url: '/admin/Master_Approval_insert',
            data: JSON.stringify(model),
            contentType: "application/json; charset=utf-8",
            success: function (response) {
                var data = response.results

                if (data.statusCode == 200) {
                    bootbox.alert(data.message, function () {
                        debugger
                        Detail(routeId)
                    })
                }
                else if (data.statusCode == 400) { bootbox.alert(data.message) }
                else {
                    bootbox.alert("Update Error!")
                }
            }
        })
    }
    function Delete() {
        approvalId = $(this).attr('data-approvalId');
        debugger
        //routeid = parseInt(document.getElementById('btn-add').getAttribute('data-routeid')); // parseInt($(this).attr('data-routeid'))
        username = $(this).attr('data-username');
        var model = new Object();
        model.ApprovalId = parseInt(approvalId);
        model.UpdatedBy = user;
        $.ajax({
            type: 'post',
            url: '/admin/Master_Approval_delete',
            data: JSON.stringify(model),
            contentType: "application/json; charset=utf-8",
            success: function (response) {

                var data = response.results;
                if (data.statusCode == 200) {
                    bootbox.alert(`${username} is deleted`, function () {
                        Detail(routeId)
                    })
                }
                else {
                    bootbox.alert("Error");
                }

            }
        })
    }

})