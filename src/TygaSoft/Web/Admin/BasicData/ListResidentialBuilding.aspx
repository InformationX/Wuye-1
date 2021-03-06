﻿<%@ Page Title="楼信息列表" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ListResidentialBuilding.aspx.cs" Inherits="TygaSoft.Web.Admin.BasicData.ListResidentialBuilding" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="server">

<div id="toolbar" style="padding:5px;">
    楼号：<input type="text" runat="server" id="txtName" maxlength="50" class="txt" />
    <a href="javascript:void(0)" class="easyui-linkbutton" data-options="iconCls:'icon-search'" onclick="ListResidentialBuilding.Search()">查 詢</a>
    <a href="javascript:void(0)" class="easyui-linkbutton" data-options="iconCls:'icon-add',plain:true" onclick="ListResidentialBuilding.Add()">新 增</a>
    <a href="javascript:void(0)" class="easyui-linkbutton" data-options="iconCls:'icon-edit',plain:true" onclick="ListResidentialBuilding.Edit()">编 辑</a>
    <a href="javascript:void(0)" class="easyui-linkbutton" data-options="iconCls:'icon-remove',plain:true" onclick="ListResidentialBuilding.Del()">删 除</a>
</div>

<table id="dgT" class="easyui-datagrid" title="楼列表" data-options="rownumbers:true,pagination:true,fit:true,fitColumns:true,toolbar:'#toolbar'">
    <thead>
        <tr>
            <th data-options="field:'f0',checkbox:true"></th>
            <th data-options="field:'f1',width:120">楼号</th>
            <th data-options="field:'f2',width:120">建筑面积</th>
            <th data-options="field:'f3',width:120">所属物业单位</th>
            <th data-options="field:'f4',width:120">所属小区</th>
            <th data-options="field:'f5',width:200">备注</th>
            <th data-options="field:'f6',width:110">最后更新时间</th>
           
        </tr>
    </thead>
    <tbody>
    <asp:Repeater ID="rpData" runat="server">
        <ItemTemplate>
            <tr>
                <td><%#Eval("Id")%></td>
                <td><%#Eval("BuildingCode")%></td>
                <td><%#Eval("CoveredArea")%></td>
                <td><%#Eval("CompanyName")%></td>
                <td><%#Eval("CommunityName")%></td>
                <td><%#Eval("Remark").ToString().Length > 16 ? Eval("Remark").ToString().Substring(0, 16) + "......" : Eval("Remark")%></td>
                <td><%#((DateTime)Eval("LastUpdatedDate")).ToString("yyyy-MM-dd HH:ss")%></td>
            </tr>
        </ItemTemplate>
    </asp:Repeater>
    </tbody>
</table>

<asp:Literal runat="server" ID="ltrMyData"></asp:Literal>

<script type="text/javascript" src="/House/Scripts/Admin/ListResidentialBuilding.js"></script>

<script type="text/javascript">
    var sPageIndex = 0;
    var sPageSize = 0;
    var sTotalRecord = 0;
    var sQueryStr = "";

    $(function () {
        try {
            var myData = ListResidentialBuilding.GetMyData("myDataForPage");
            $.map(myData, function (item) {
                sPageIndex = parseInt(item.PageIndex);
                sPageSize = parseInt(item.PageSize);
                sTotalRecord = parseInt(item.TotalRecord);
                sQueryStr = item.QueryStr.replace(/&amp;/g, '&');
            })

            ListResidentialBuilding.Init();
        }
        catch (e) {
            $.messager.alert('错误提醒', e.name + ": " + e.message, 'error');
        }
        
    })
</script>

</asp:Content>
