﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CMS.Login1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <style>
        body{
            margin: 0 auto 0 auto;  
            width:100%; 
            text-align:center;
            margin: 20px 0px 20px 0px;   
        }

        p{
            font-size:12px;
            text-decoration: none;
            color:;
        }

        h1{
            font-size:1.5em;
            color:#525252;
        }

        .box{
            background:white;
            width:300px;
            border-radius:6px;
            margin: 0 auto 0 auto;
            padding:0px 0px 70px 0px;
            border: #2980b9 4px solid; 
        }

        .email{
            background:#ecf0f1;
            border: #ccc 1px solid;
            border-bottom: #ccc 2px solid;
            padding: 8px;
            width:250px;
            color:#AAAAAA;
            margin-top:10px;
            font-size:1em;
            border-radius:4px;
        }


        .btn{
            background:#3498db;
            width:125px;
            padding-top:5px;
            padding-bottom:5px;
            color:white;
            border-radius:4px;
            border: #27ae60 1px solid;
  
            margin-top:20px;
            margin-bottom:20px;
            font-weight:800;
            font-size:0.8em;
        }

        .btn:hover{
        }

    </style>    
    

        <div class="box">
        <h1>Login</h1>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="email" placeholder="Username"></asp:TextBox>
        <%--<input type="email" name="email" value="email" onFocus="field_focus(this, 'email');" onblur="field_blur(this, 'email');" class="email" />--%>
        
        <asp:TextBox ID="TextBox2" runat="server" CssClass="email" placeholder="Password" TextMode="Password"></asp:TextBox>
        <%--<input type="password" name="email" value="email" onFocus="field_focus(this, 'email');" onblur="field_blur(this, 'email');" class="email" />--%>
  
        <a href="#"><asp:Button ID="Button1" runat="server" CssClass="btn" Text="Login" OnClick="Button1_Click"/> </a> <!-- End Btn -->
            <br />
        <asp:Label ID="LabelError" runat="server" Visible="False"></asp:Label>
            <br />
        <a href="Signup.aspx"><asp:Button ID="Button2" runat="server" CssClass="btn2" Text="Sign Up"/></a> <!-- End Btn2 -->
  
        
        </div> <!-- End Box -->
  
        

        <p>Forgot your password? <u style="color:#f1c40f;">Click Here!</u></p>

    <!-   --->

</asp:Content>
