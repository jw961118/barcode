<%@ Page Language="C#" %>
<%@ Import Namespace="OnBarcode.Barcode.ASPNET" %>
<%
    MicroPDF417WebStream.drawBarcode(Request, Response);
%>
