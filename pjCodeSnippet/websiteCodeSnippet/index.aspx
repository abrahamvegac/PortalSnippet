<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="websiteCodeSnippet.index" %>
<%@ Register src="controlesUsuarios/WebUserControl1.ascx" tagname="WebUserControl1" tagprefix="uc1" %>
<%@ Register src="controlesUsuarios/menuCategoria.ascx" tagname="menuCategoria" tagprefix="uc2" %>
<%@ Register src="controlesUsuarios/panelFooter.ascx" tagname="panelFooter" tagprefix="uc3" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="content-type" content="text/html; charset=utf-8" />
    <title>Neosoft Code Snippet</title>
    <meta name="keywords" content="" />
    <meta name="description" content="" />
    <link href="Styles/default.css"  rel="stylesheet" type="text/css" />

</head>
<body>
    <form id="form1" runat="server">
<div id="header">
	<div id="logo">
		<h1><span><a href="#">Code</a></span>Snippet</h1>
		<h2><a href="#">codigos de ayuda</a></h2>
	</div>
	<div id="menu">

    <uc1:WebUserControl1 ID="WebUserControl11" runat="server" />
<!--
		<ul>
			<li class="first"><a href="#" accesskey="1" title="">Inicio</a></li>
			<li><a href="#" accesskey="2" title="">Snippet</a></li>
			<li><a href="#" accesskey="3" title="">Registrar</a></li>
			<li><a href="#" accesskey="5" title="">Administrar</a></li>
		</ul>
//-->
	</div>



</div>
<div id="splash"><a href="#"><img src="images/img4.jpg" alt="" width="877" height="140" /></a></div>
<div id="content">

	<div id="colOne"> <!-- inicio de la columna ONE //--> 

		<h2>
            <asp:Label ID="lbl_titulopanel" runat="server"></asp:Label>
        </h2>

		<p>
            <asp:Label ID="lbl_cuerpopanel" runat="server"></asp:Label>        
        </p>

        <!--
		<p>Sed vel quam. Vestibulum pellentesque. Morbi sit amet magna ac lacus dapibus interdum. Donec pede nisl, Maecenas sed sem sit amet lectus mattis molestie. Integer quis eros lorem ipsum dolor sit amet.</p>
		<div class="posted">
			<p>posted by <a href="#">Someone</a> on January 10, 2007</p>
			<p class="comments"><a href="#">64 comments</a></p>
		</div>
        //-->

        <!--
		<h2>Lorem Ipsum Dolor</h2>
		<p>Sed vel quam. Vestibulum pellentesque. Morbi sit amet magna ac lacus dapibus interdum. Donec pede nisl, Maecenas sed sem sit amet lectus mattis molestie. Integer quis eros lorem ipsum dolor sit amet. Sed vel quam. Vestibulum pellentesque. Morbi sit amet magna ac lacus dapibus interdum. Donec pede nisl, Maecenas sed sem sit amet lectus mattis molestie. Integer quis eros lorem ipsum dolor sit amet.</p>
		<div class="posted">
			<p>posted by <a href="#">Someone</a> on January 10, 2007</p>
			<p class="comments"><a href="#">32 comments</a></p>
		</div>
       //-->
	</div> <!-- fin de la columna ONE //--> 


	<div id="colTwo">
		<h3>Buscar</h3>
			<div>
				<input name="textfield1" type="text" id="textfield1" />
				<input name="submit1" type="submit" id="submit1" value="buscar" />
			</div>


		<p></p>


		<h3>Categorias</h3>

		<uc2:menuCategoria ID="menuCategoria1" runat="server" />

        <!--
		<ul>
			<li><a href="#">Sed vel quam nulla</a></li>
			<li><a href="#">Vestibulum pellentesque</a></li>
			<li><a href="#">Morbi sit amet magna </a></li>
			<li><a href="#">Lacus dapibus interdum</a></li>
			<li><a href="#">Donec pede nisl dolore</a></li>
			<li><a href="#">Maecenas sed sem</a></li>
		</ul>
        //-->

	</div>
	<div style="clear: both;">&nbsp;</div>
</div>
<div id="footer">
	<!-- <p>(c) 2012 code Snippet. diseñado por avega(neosoft).</p> //--> 

    <p>
    <uc3:panelFooter ID="panelFooter1" runat="server" />
    </p>

</div>
    </form>
</body>
</html>