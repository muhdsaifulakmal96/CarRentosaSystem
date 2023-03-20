<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CarRental._Default" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">
      
        function Confirm() {
            var confirm_value = document.createElement("INPUT");
            confirm_value.type = "hidden";
            confirm_value.name = "confirm_value";
            if (confirm("Anda Ingin Padam Data?")) {
                confirm_value.value = "Yes";
            } else {
                confirm_value.value = "No";
            }
            document.forms[0].appendChild(confirm_value);
        }
    </script>
    <div class="jumbotron">
        <h1 class="display-3 text-primary text-center">Car Rentosa</h1>
        <h1 class="display-4 text-uppercase text-center mb-5">Sewa Kenderaan Disini</h1>
        <h1>Selamat Datang!</h1>
        <p class="lead">Selamat Datang Ke Rentos</p>        
        <p><asp:Button ID="btnAdd" runat="server" class="btn btn-primary btn-lg" OnClick="btnAdd_Click" Text="Tambah Kenderaan" /></p>             
    </div>
    

    <div class="row">
        <!-- Rent A Car Start -->
            <div class="container pt-5 pb-3">
                <div class="row">
                    <!-- Repeater Start -->
                    <asp:Repeater ID="repeatCarTiles" runat="server">
                        <HeaderTemplate>
                        </HeaderTemplate>
                        <ItemTemplate>
                        <div class="col-lg-4 col-md-6 mb-2">
                            <div class="rent-item mb-4">
                                <asp:HiddenField ID="car_id_hiddenfield" runat="server" value='<%# Eval("car_id") %>' />
                              
                                <img class="img-fluid mb-4" src="img/KERETA/<%# Eval("car_image") %>" alt="">
                                <h4 class="text-uppercase mb-4"><%# Eval("car_name") %></h4>
                                <div class="d-flex justify-content-center mb-4">
                                    <div class="px-2">
                                        <i class="fa fa-car text-primary mr-1"></i>
                                        <span><%# Eval("car_model_year") %></span>
                                    </div>
                                    <div class="px-2 border-left border-right">
                                        <i class="fa fa-cogs text-primary mr-1"></i>
                                        <span><%# Eval("transmission_type") %></span>
                                    </div>
                                    <div class="px-2">
                                        <i class="fa fa-road text-primary mr-1"></i>
                                        <span><%# formatMileageTxt((decimal)DataBinder.Eval(Container, "DataItem.car_mileage")) %></span>
                                    </div>                                    
                                </div>
                                <div class="d-flex justify-content-center mb-4">
                                    <div class="px-2">                                                                 
                                        <asp:LinkButton ID="LinkButtonEdit" runat="server" class="btn" OnCommand="lnkEdit_Click" CommandArgument=<%# Eval("car_id") %>><i class="fa fa-pencil-alt text-primary mr-1"></i> Edit</asp:LinkButton>
                                        
                                    </div>
                                    <div class="px-2 border-left border-right">
                                        <asp:LinkButton ID="LinkButtonDelete" runat="server" class="btn" OnClick="OnConfirm" OnClientClick="Confirm()" CommandArgument=<%# Eval("car_id") %>><i class="fa fa-trash text-primary mr-1"></i> Delete</asp:LinkButton> 
                                    </div>
                                </div>
                                <span>RM<%# Eval("rate_per_hour") %>/hour</span>
                                <asp:LinkButton ID="lnkOrder" runat="server" class="btn btn-primary px-3" OnCommand="lnkOrder_Click" CommandArgument=<%# Eval("car_id") %>>Tempah</asp:LinkButton> 
                            </div>
                        </div>
                        </ItemTemplate>
                        <FooterTemplate>
                        </FooterTemplate>
                    </asp:Repeater>
                    <!-- Repeater End -->
                </div>
            </div>
        <!-- Rent A Car End -->

    </div>

</asp:Content>
