<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="TeamCollaboration.Web.Demo.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="http://localhost/TeamCollaboration.Web/Scripts/jquery-1.10.2.js"></script>
    <link href="http://localhost/TeamCollaboration.Web/Content/bootstrap.css" rel="stylesheet" />
    <link href="http://localhost/TeamCollaboration.Web/Content/TeamCollaboration.css" rel="stylesheet" />
    <script src="http://localhost/TeamCollaboration.Web/Scripts/bootstrap.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script>
        function show() {
            $('.PersonalCenter').show();
        }
        function unShow() {
            $('.PersonalCenter').hide();
        }
        $(function () {
            $('#Contacts a:first').tab('show');//初始化显示哪个tab 
            $('#Contacts a').click(function (e) {
                e.preventDefault();//阻止a链接的跳转行为 
                $(this).tab('show');//显示当前选中的链接及关联的content
            })
        })
        $('#Contacts a[href="#profile"]').tab('show'); // Select tab by name 
        $('#Contacts a:first').tab('show'); // Select first tab 
        $('#Contacts a:last').tab('show'); // Select last tab 
        $('#Contacts li:eq(2) a').tab('show');
    </script>
</head>
<body>
    <%--head--%>
    <div id="header">
        <div class="col-xs-1 col-md-1">
            <a href="Index.aspx" class="header-logo"></a>
        </div>
        <div class="col-xs-1 col-md-1 header-text">协作平台</div>
        <div class="col-xs-9 col-md-9"></div>
        <div class="col-xs-1 col-md-1">
            <span class="btn header-personal" onclick="show()"></span>
            <a class="header-text1">[退出]</a>
        </div>
    </div>

    <%--Personal Center--%>
    <div class="PersonalCenter">
        <button type="button" class="btn glyphicon glyphicon-minus narrow" onclick="unShow()"></button>
        <div class="Headportrait"></div>
        <div class="name">XXX</div>
        <div>
            <input type="text" class="SearchBox" value="搜索：联系人、讨论组" onfocus="if(this.value=='搜索：联系人、讨论组')this.value=''" onblur="if(this.value=='')this.value='搜索：联系人、讨论组'"/>           
        </div>
        <div>
            <ul class="nav nav-tabs" id="Contacts">
                <li class="active tab-Contacts">
                    <a href="#friend" class="tab-ContactsText">
                        <span class="tab-personal"></span>
                        <div class="tab-personalText">联系人</div>
                    </a>
                </li>
                <li class="tab-Contacts">
                    <a href="#group" class="tab-ContactsText">
                        <span class="tab-group"></span>
                        <div class="tab-groupText">讨论组</div>
                    </a>
                </li>
            </ul>

            <div class="tab-content">
                <div class="tab-pane active" id="friend">11</div>
                <div class="tab-pane" id="group">1111</div>
            </div>
        </div>

        <div class="chatfeatureList">
            <span class="btn glyphicon glyphicon-volume-up messageAlerts"></span>
            <div>
                <span class="glyphicon glyphicon-plus addUser"></span>
                <span class="addUserText">添加用户</span>
            </div>
            <div>
                <span class="glyphicon glyphicon-trash deleteUser"></span>
                <span class="deleteUserText">删除用户</span>
            </div>
        </div>
    </div>

    <%--detail--%>
    <div class="container-fluid">

        <%--menu--%>
        <div class="col-xs-1 col-md-1" id="menu">
            <div class="row empty"></div>
            <div class="row home"></div>
            <div class="row task"></div>
            <div class="row meeting"></div>
            <div class="row file"></div>
        </div>
    </div>
</body>
</html>
