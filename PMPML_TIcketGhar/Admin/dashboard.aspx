<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dashboard.aspx.cs" Inherits="PMPML_TIcketGhar.Admin.dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>PMPML( तिकीट घर) Dashboard</title>
    <link rel="stylesheet" href="Dashbord_final_styles.css">
</head>
<body>
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
                <p>1234</p>
            </div>
            <div class="stat-item" id="total-revenue">
                <div class="title">Total Revenue Generated for Today</div>
                <p>5678 rs</p>
            </div>
            <div class="stat-item" id="total-penalty">
                <div class="title">Total Penalty</div>
                <p>90 rs</p>
            </div>
        </div>

        <div class="passes">
            <div class="pass-item" id="daily-pass">
                <div class="title">Today's Daily Pass Granted</div>
                <p>234</p>
            </div>
            <div class="pass-item" id="monthly-pass">
                <div class="title">Today's Monthly Pass Granted</div>
                <p>56</p>
            </div>
            <div class="pass-item" id="yearly-pass">
                <div class="title">Yearly Pass Granted</div>
                <p>12</p>
            </div>
        </div>

        <!-- Bus Data Table -->
        <div class="table-container">
            <table>
                <thead>
                    <tr>
                        <th>Bus Number</th>
                        <th>Bus ID</th>
                        <th>Total Tickets</th>
                        <th>Total Revenue</th>
                        <th>Total Penalty</th>
                        <th>Daily Pass</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>MH12AB1234</td>
                        <td>1001</td>
                        <td>150</td>
                        <td>300rs</td>
                        <td>10rs</td>
                        <td>10</td>
                    </tr>
                    <tr>
                        <td>MH12CD5678</td>
                        <td>1002</td>
                        <td>200</td>
                        <td>400rs</td>
                        <td>20rs</td>
                        <td>20</td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>

    <script src="script.js"></script>
    <%--<form id="form1" runat="server">
        <div>
        </div>
    </form>--%>
</body>
</html>
