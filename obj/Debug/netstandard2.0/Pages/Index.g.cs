#pragma checksum "/Users/gersonreply/Documents/Gerson .Net/ConsoleEncryption/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ba88514633f44b26928ddb8a1df254997da00eb"
// <auto-generated/>
#pragma warning disable 1591
namespace ConsoleEncryption.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using Microsoft.JSInterop;
    using ConsoleEncryption;
    using ConsoleEncryption.Shared;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/")]
    public class Index : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.AddMarkupContent(0, "<h1>Encrypt and Decrypt</h1>\n");
            builder.OpenElement(1, "div");
            builder.AddAttribute(2, "class", "form-group");
            builder.AddContent(3, "\n");
#line 5 "/Users/gersonreply/Documents/Gerson .Net/ConsoleEncryption/Pages/Index.cshtml"
     if (strkey.Length>0)
    {

#line default
#line hidden
            builder.AddContent(4, "        ");
            builder.AddMarkupContent(5, "<div class=\"alert alert-success\" role=\"alert\">\n            File got it!!\n        </div>\n");
#line 10 "/Users/gersonreply/Documents/Gerson .Net/ConsoleEncryption/Pages/Index.cshtml"
        
    }else
    {


#line default
#line hidden
            builder.AddContent(6, "        ");
            builder.AddMarkupContent(7, "<div class=\"alert alert-danger\" role=\"alert\">\n            File empty\n        </div>\n");
#line 17 "/Users/gersonreply/Documents/Gerson .Net/ConsoleEncryption/Pages/Index.cshtml"
    }

#line default
#line hidden
            builder.AddContent(8, "    ");
            builder.OpenElement(9, "div");
            builder.AddAttribute(10, "class", "custom-file");
            builder.AddContent(11, "\n        ");
            builder.OpenElement(12, "input");
            builder.AddAttribute(13, "type", "file");
            builder.AddAttribute(14, "class", "custom-file-input");
            builder.AddAttribute(15, "id", "customFileLang");
            builder.AddAttribute(16, "lang", "en");
            builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIChangeEventArgs>(changekey));
            builder.AddElementReferenceCapture(18, (__value) => {
#line 19 "/Users/gersonreply/Documents/Gerson .Net/ConsoleEncryption/Pages/Index.cshtml"
                                inputkeyref = __value;

#line default
#line hidden
            }
            );
            builder.CloseElement();
            builder.AddContent(19, "\n        ");
            builder.AddMarkupContent(20, "<label class=\"custom-file-label\" for=\"customFileLang\">search Key</label>\n    ");
            builder.CloseElement();
            builder.AddContent(21, "\n");
#line 22 "/Users/gersonreply/Documents/Gerson .Net/ConsoleEncryption/Pages/Index.cshtml"
     if (strFile.Length>0)
    {

#line default
#line hidden
            builder.AddContent(22, "        ");
            builder.AddMarkupContent(23, "<div class=\"alert alert-success\" role=\"alert\">\n            File got it!!\n        </div>\n");
#line 27 "/Users/gersonreply/Documents/Gerson .Net/ConsoleEncryption/Pages/Index.cshtml"
        
    }else
    {


#line default
#line hidden
            builder.AddContent(24, "        ");
            builder.AddMarkupContent(25, "<div class=\"alert alert-danger\" role=\"alert\">\n            File empty\n        </div>\n");
#line 34 "/Users/gersonreply/Documents/Gerson .Net/ConsoleEncryption/Pages/Index.cshtml"
    }

#line default
#line hidden
            builder.AddContent(26, "\n");
#line 36 "/Users/gersonreply/Documents/Gerson .Net/ConsoleEncryption/Pages/Index.cshtml"
     if(strkey.Length>0)
    {

#line default
#line hidden
            builder.AddContent(27, "        ");
            builder.OpenElement(28, "div");
            builder.AddAttribute(29, "class", "custom-file mt-1");
            builder.AddContent(30, "\n            ");
            builder.OpenElement(31, "input");
            builder.AddAttribute(32, "type", "file");
            builder.AddAttribute(33, "class", "custom-file-input");
            builder.AddAttribute(34, "id", "customFileLang");
            builder.AddAttribute(35, "lang", "en");
            builder.AddAttribute(36, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIChangeEventArgs>(changefile));
            builder.AddElementReferenceCapture(37, (__value) => {
#line 39 "/Users/gersonreply/Documents/Gerson .Net/ConsoleEncryption/Pages/Index.cshtml"
                                    inputfileref = __value;

#line default
#line hidden
            }
            );
            builder.CloseElement();
            builder.AddContent(38, "\n            ");
            builder.AddMarkupContent(39, "<label class=\"custom-file-label\" for=\"customFileLang\">search File</label>\n        ");
            builder.CloseElement();
            builder.AddContent(40, "\n");
#line 42 "/Users/gersonreply/Documents/Gerson .Net/ConsoleEncryption/Pages/Index.cshtml"
    }

#line default
#line hidden
            builder.AddContent(41, "    \n");
#line 44 "/Users/gersonreply/Documents/Gerson .Net/ConsoleEncryption/Pages/Index.cshtml"
     if (strFile.Length>0&&strkey.Length>0)
    {

#line default
#line hidden
            builder.AddContent(42, "        ");
            builder.OpenElement(43, "div");
            builder.AddAttribute(44, "class", "row");
            builder.AddContent(45, "\n            ");
            builder.OpenElement(46, "div");
            builder.AddAttribute(47, "class", "col-md-6");
            builder.AddContent(48, "\n");
#line 48 "/Users/gersonreply/Documents/Gerson .Net/ConsoleEncryption/Pages/Index.cshtml"
                 if(swbol)
                {

#line default
#line hidden
            builder.AddContent(49, "                    ");
            builder.OpenElement(50, "button");
            builder.AddAttribute(51, "class", "btn bg-primary");
            builder.AddAttribute(52, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(EncryptData));
            builder.AddContent(53, "Encrypt");
            builder.CloseElement();
            builder.AddContent(54, "\n");
#line 51 "/Users/gersonreply/Documents/Gerson .Net/ConsoleEncryption/Pages/Index.cshtml"
                }

#line default
#line hidden
            builder.AddContent(55, "                \n            ");
            builder.CloseElement();
            builder.AddContent(56, "\n            ");
            builder.OpenElement(57, "div");
            builder.AddAttribute(58, "class", "col-md-6");
            builder.AddContent(59, "\n");
#line 55 "/Users/gersonreply/Documents/Gerson .Net/ConsoleEncryption/Pages/Index.cshtml"
                 if(!swbol)
                {

#line default
#line hidden
            builder.AddContent(60, "                    ");
            builder.OpenElement(61, "button");
            builder.AddAttribute(62, "class", "btn bg-primary");
            builder.AddAttribute(63, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(DecryptData));
            builder.AddContent(64, "Decrypt");
            builder.CloseElement();
            builder.AddContent(65, "\n");
#line 58 "/Users/gersonreply/Documents/Gerson .Net/ConsoleEncryption/Pages/Index.cshtml"
                }

#line default
#line hidden
            builder.AddContent(66, "                \n            ");
            builder.CloseElement();
            builder.AddContent(67, "\n        ");
            builder.CloseElement();
            builder.AddContent(68, "    \n");
#line 62 "/Users/gersonreply/Documents/Gerson .Net/ConsoleEncryption/Pages/Index.cshtml"
    }

#line default
#line hidden
            builder.AddContent(69, "    ");
            builder.OpenElement(70, "input");
            builder.AddAttribute(71, "type", "checkbox");
            builder.AddAttribute(72, "checked", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(swbol));
            builder.AddAttribute(73, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => swbol = __value, swbol));
            builder.CloseElement();
            builder.AddContent(74, "\n");
#line 64 "/Users/gersonreply/Documents/Gerson .Net/ConsoleEncryption/Pages/Index.cshtml"
     if(swbol)
    {
        int i=-1;

#line default
#line hidden
            builder.AddContent(75, "        ");
            builder.OpenElement(76, "div");
            builder.AddAttribute(77, "class", "form-group");
            builder.AddContent(78, "\n            ");
            builder.AddMarkupContent(79, "<label>Nueva Linea</label>\n            ");
            builder.OpenElement(80, "input");
            builder.AddAttribute(81, "class", "form-control");
            builder.AddAttribute(82, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(newline));
            builder.AddAttribute(83, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => newline = __value, newline));
            builder.CloseElement();
            builder.AddContent(84, "\n        ");
            builder.CloseElement();
            builder.AddContent(85, "\n        ");
            builder.OpenElement(86, "button");
            builder.AddAttribute(87, "class", "btn bg-primary");
            builder.AddAttribute(88, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(AddLine));
            builder.AddContent(89, "Add Line");
            builder.CloseElement();
            builder.AddContent(90, "\n        ");
            builder.OpenElement(91, "ul");
            builder.AddAttribute(92, "class", "list-group mt-3");
            builder.AddContent(93, "\n");
#line 73 "/Users/gersonreply/Documents/Gerson .Net/ConsoleEncryption/Pages/Index.cshtml"
             foreach (var item in list)
            {
                i++;

#line default
#line hidden
            builder.AddContent(94, "                ");
            builder.OpenElement(95, "li");
            builder.AddAttribute(96, "class", "list-group-item");
            builder.AddContent(97, i);
            builder.AddContent(98, " .-  ");
            builder.AddContent(99, item);
            builder.AddContent(100, " \n                    ");
            builder.OpenElement(101, "span");
            builder.AddAttribute(102, "class", "badge badge-danger badge-pill");
            builder.AddAttribute(103, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(()=>RemoveLine(item)));
            builder.AddContent(104, "remove");
            builder.CloseElement();
            builder.AddContent(105, "\n                ");
            builder.CloseElement();
            builder.AddContent(106, "   \n");
#line 79 "/Users/gersonreply/Documents/Gerson .Net/ConsoleEncryption/Pages/Index.cshtml"
                
            }        

#line default
#line hidden
            builder.AddContent(107, "        ");
            builder.CloseElement();
            builder.AddContent(108, "\n");
#line 82 "/Users/gersonreply/Documents/Gerson .Net/ConsoleEncryption/Pages/Index.cshtml"
    }
    else
    {

#line default
#line hidden
            builder.AddContent(109, "        ");
            builder.OpenElement(110, "textarea");
            builder.AddAttribute(111, "readonly", true);
            builder.AddAttribute(112, "class", "form-control");
            builder.AddAttribute(113, "rows", "15");
            builder.AddAttribute(114, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(strencrypt));
            builder.AddAttribute(115, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => strencrypt = __value, strencrypt));
            builder.AddContent(116, " \n          \n        ");
            builder.CloseElement();
            builder.AddContent(117, "\n");
#line 88 "/Users/gersonreply/Documents/Gerson .Net/ConsoleEncryption/Pages/Index.cshtml"
    }

#line default
#line hidden
            builder.AddContent(118, "    \n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 92 "/Users/gersonreply/Documents/Gerson .Net/ConsoleEncryption/Pages/Index.cshtml"
            
    ElementRef inputkeyref;
    ElementRef inputfileref;
    string strkey="";
    string strFile="";
    bool swbol=true;
    List<string> list=new List<string>();
    string strencrypt="";
    string newline="";
    /*protected override async Task OnInitAsync(){
        
    }*/
    void RemoveLine(string item){
        Console.WriteLine("item : " + item);
        string aux=list.First(p=>p.Equals(item));
        list.Remove(aux);
    }
    void AddLine(){
        list.Insert(0,newline);
        newline="";
    }
    async Task changekey(UIChangeEventArgs evt){
        strkey = await ConsoleEncryption.Services.serviceInterop.GetFileData(inputkeyref);
        byte[] decodedBytes = Convert.FromBase64String(strkey);
        strkey = System.Text.Encoding.UTF8.GetString(decodedBytes);
        
    }
    async Task changefile(UIChangeEventArgs evt){
        strFile = await ConsoleEncryption.Services.serviceInterop.GetFileData(inputfileref);
        byte[] decodedBytes = Convert.FromBase64String(strFile);
        strFile = System.Text.Encoding.UTF8.GetString(decodedBytes);
        string[] auxstr= strFile.Split(Environment.NewLine.ToCharArray());
        strencrypt=strFile;
        FillData(auxstr);
    }
    private byte[] base64tosArrayByte(string strbase64){
        
        byte[] decodedBytes=Convert.FromBase64String(strbase64);
        return decodedBytes;
    }
    void FillData(string[] auxstr){
        list=new List<string>();
        foreach (string item in auxstr)
        {
            list.Add(item);
        }
    }
    void EncryptData(){
        //System.Security.Cryptography.Aes
        if(strkey.Length>16)
            strkey=strkey.Substring(0,16);
        byte[] key=System.Text.Encoding.UTF8.GetBytes(strkey);
        string straux="ADOTRMDWOD1QWELK";
        byte[] IV=System.Text.Encoding.UTF8.GetBytes(straux);
        string plaintext=getPlainText();
        byte[] encrypted;
        using (var aes = System.Security.Cryptography.Aes.Create())
        {
            aes.IV=IV;
            aes.Key=key;
            var encryptor=aes.CreateEncryptor(aes.Key,aes.IV);
            using (var ms=new System.IO.MemoryStream())
            {
                using (var csEncrypt=new System.Security.Cryptography.CryptoStream(ms,encryptor,
                System.Security.Cryptography.CryptoStreamMode.Write))
                {
                    using (var swEncrypt=new System.IO.StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(plaintext);
                    }
                    encrypted=ms.ToArray();
                    strencrypt=Convert.ToBase64String(encrypted);
                    swbol=!swbol;
                    list=new List<string>();
                }
            }
        }
    }
    void DecryptData(){
        //System.Security.Cryptography.Aes
        if(strkey.Length>16)
            strkey=strkey.Substring(0,16);
        byte[] key=System.Text.Encoding.UTF8.GetBytes(strkey);
        string straux="ADOTRMDWOD1QWELK";
        byte[] IV=System.Text.Encoding.UTF8.GetBytes(straux);
        byte[] encryptedText=base64tosArrayByte(strencrypt);
        using (var aes = System.Security.Cryptography.Aes.Create())
        {
            aes.IV=IV;
            aes.Key=key;
            
            var decryptor=aes.CreateDecryptor(aes.Key,aes.IV);
            using (var ms=new System.IO.MemoryStream(encryptedText))
            {
                using (var csDecrypt=new System.Security.Cryptography.CryptoStream(ms,decryptor,
                System.Security.Cryptography.CryptoStreamMode.Read))
                {
                    using (var swDecrypt=new System.IO.StreamReader(csDecrypt))
                    {
                        strFile=swDecrypt.ReadToEnd();
                        FillData(strFile.Split(Environment.NewLine.ToCharArray()));
                        swbol=!swbol;
                        strencrypt="";
                    }
                }
            }
        }
    }
    
    private string getPlainText(){
        string plaintext="";
        foreach (string item in list)
        {
            plaintext= plaintext+item+Environment.NewLine;
        }
        return plaintext;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
