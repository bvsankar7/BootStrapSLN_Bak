<%@ Page Title="" Language="C#" MasterPageFile="~/BootStrapCheckMate.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BootStrampCheckMate.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%--<link href="css/Custom.css" rel="stylesheet" />--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Carousel Image Slider -->
    <div id="carousel-example-generic" class="carousel slide" data-ride="carousel">
        <!-- Indicators -->
        <ol class="carousel-indicators">
            <li data-target="#carousel-example-generic" data-slide-to="0" class="active"></li>
            <li data-target="#carousel-example-generic" data-slide-to="1"></li>
            <li data-target="#carousel-example-generic" data-slide-to="2"></li>
        </ol>

        <!-- Wrapper for slides -->
        <div class="carousel-inner" role="listbox">
            <div class="item active">
                <img src="Images/IMG_187851.jpg" alt="..." style="width: 100%; height: 400px" />
                <div class="carousel-caption">
                    <h3>Pleasent Climate</h3>
                    <p>Wow!  Its Amezing Forest</p>
                    <p><a class="btn btn-lg btn-primary" role="button" href="#">Join Us Today</a></p>
                </div>
            </div>
            <div class="item">
                <img src="Images/IMG_187861.jpg" alt="..." style="width: 100%; height: 400px" />
                <div class="carousel-caption">
                    <h3>New Windows Operating System</h3>
                    <p>Modern OS</p>

                </div>
            </div>
            <div class="item">
                <img src="Images/IMG_187873.jpg" alt="..." style="width: 100%; height: 400px" />
                <div class="carousel-caption">
                    <h3>Beautiful Village</h3>
                    <p>See What a Wonder</p>

                </div>
            </div>
            ...
 
        </div>

        <!-- Controls -->
        <a class="left carousel-control" href="#carousel-example-generic" role="button" data-slide="prev">
            <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
            <span class="sr-only">Previous</span>
        </a>
        <a class="right carousel-control" href="#carousel-example-generic" role="button" data-slide="next">
            <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
            <span class="sr-only">Next</span>
        </a>
    </div>
    <!-- Carousel End-->
    <br />
    <br />
    <asp:FileUpload ID="FileUpload1" runat="server" />
<asp:Button ID="Button1" runat="server" Text="Upload" OnClick="Button1_Click" />
  
<asp:Panel ID="Panel1" runat="server" Width="100%">

</asp:Panel>
    <div class="container center">
        <div class="row">
            <div class="col-lg-4">
                <img class="img-circle" src="Images/bike2.jpg" width="140" height="140" />
                <h2>Hello</h2>
                <p>A definition of "matter" based on its physical and chemical structure is: matter is made up of atoms.[15] As an example, deoxyribonucleic acid molecules (DNA) are matter under this definition because they are made of atoms. This definition can extend to include charged atoms and molecules, so as to include plasmas (gases of ions) and electrolytes (ionic solutions), which are not obviously included in the atoms definition. Alternatively, one can adopt the protons, neutrons, and electrons definition.</p>
                <p><a class="btn-default" href="#" role="button">View &raquo;</a></p>

            </div>

            <div class="col-lg-4">
                <img class="img-circle" src="Images/bike4.jpg" width="140" height="140" />
                <h2>Hello</h2>
                <p>A definition of "matter" based on its physical and chemical structure is: matter is made up of atoms.[15] As an example, deoxyribonucleic acid molecules (DNA) are matter under this definition because they are made of atoms. This definition can extend to include charged atoms and molecules, so as to include plasmas (gases of ions) and electrolytes (ionic solutions), which are not obviously included in the atoms definition. Alternatively, one can adopt the protons, neutrons, and electrons definition.</p>
                <p><a class="btn-default" href="#" role="button">View &raquo;</a></p>

            </div>

            <div class="col-lg-4">
                <img class="img-circle" src="Images/mobile2.png" width="140" height="140" />
                <h2>Hello</h2>
                <p>A definition of "matter" based on its physical and chemical structure is: matter is made up of atoms.[15] As an example, deoxyribonucleic acid molecules (DNA) are matter under this definition because they are made of atoms. This definition can extend to include charged atoms and molecules, so as to include plasmas (gases of ions) and electrolytes (ionic solutions), which are not obviously included in the atoms definition. Alternatively, one can adopt the protons, neutrons, and electrons definition.</p>
                <p><a class="btn-default" href="#" role="button">View &raquo;</a></p>

            </div>
        </div>
    </div>
    
</asp:Content>
