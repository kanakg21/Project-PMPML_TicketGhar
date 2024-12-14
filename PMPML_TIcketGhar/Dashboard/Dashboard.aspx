<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="PMPML_TIcketGhar.Dashboard.Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<title>PMPML( तिकीट घर) Dashboard</title>
<link rel="stylesheet" type="text/css" href="DashboardStyles.css" />
<script src="https://cdn.jsdelivr.net/npm/chart.js"></script>
</head>
<body>
     <form id="form1" runat="server">
     <!-- Navigation Bar -->
     <nav>
         <div class="logo">PMPML(तिकीट घर)</div>
         <ul>
             <li><a href="#">Home</a></li>
             <li><a href="#">Contact</a></li>
         </ul>
     </nav>

     <!-- Main Dashboard Content -->
     <div class="dashboard">
         <div class="stats">
             <div class="stat-item" id="total-tickets">
                 <div class="title">Total Tickets for Today</div>
                 <asp:Label ID="lblTotalTickets" runat="server" Text="Loading..."></asp:Label>
             </div>
             <div class="stat-item" id="total-revenue">
                 <div class="title">Total Revenue Generated for Today</div>
                 <asp:Label ID="lblTotalRevenue" runat="server" Text="Loading..."></asp:Label>
             </div>
             <div class="stat-item" id="total-penalty">
                 <div class="title">Total Penalty</div>
                 <asp:Label ID="lblTotalPenalty" runat="server" Text="Loading..."></asp:Label>
             </div>
         </div>

         <div class="passes">
             <div class="pass-item" id="daily-pass">
                 <div class="title">Today's Daily Pass Granted</div>
                 <asp:Label ID="lblDailyPass" runat="server" Text="Loading..."></asp:Label>
             </div>
             <div class="pass-item" id="monthly-pass">
                 <div class="title">Today's Monthly Pass Granted</div>
                 <asp:Label ID="lblMonthlyPass" runat="server" Text="Loading..."></asp:Label>
             </div>
             <div class="pass-item" id="yearly-pass">
                 <div class="title">Yearly Pass Granted</div>
                 <asp:Label ID="lblYearlyPass" runat="server" Text="Loading..."></asp:Label>
             </div>
         </div>

         <!-- Graph Section -->
         <div class="graph-section">
             <canvas id="myChart"></canvas>
         </div>
     </div>
 </form>
 <script src="script.js"></script>
</body>
</html>
