<%@ Page Language="C#" %>
<%@ Import Namespace="OnBarcode.Barcode.ASPNET" %>
<%
    MicroQRCodeWebStream.drawBarcode(Request, Response);
%>
