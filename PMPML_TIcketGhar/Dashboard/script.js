// Example script to dynamically update the dashboard and create a chart
document.addEventListener('DOMContentLoaded', function () {
    // Fetch data from the server and update the dashboard
    fetchDataAndUpdateDashboard();

    // Create a chart
    createChart();
});

function fetchDataAndUpdateDashboard() {
    // Placeholder data
    const data = {
        totalTickets: 1,
        totalRevenue: 1700.00,
        totalPenalty: 500.00,
        dailyPass: 1,
        monthlyPass: 1,
        yearlyPass: 1
    };

    // Update the dashboard with fetched data
    document.getElementById('lblTotalTickets').textContent = data.totalTickets;
    document.getElementById('lblTotalRevenue').textContent = data.totalRevenue + ' rs';
    document.getElementById('lblTotalPenalty').textContent = data.totalPenalty + ' rs';
    document.getElementById('lblDailyPass').textContent = data.dailyPass;
    document.getElementById('lblMonthlyPass').textContent = data.monthlyPass;
    document.getElementById('lblYearlyPass').textContent = data.yearlyPass;
}

function createChart() {
    const ctx = document.getElementById('myChart').getContext('2d');
    const myChart = new Chart(ctx, {
        type: 'doughnut',
        data: {
            labels: ['Total Tickets', 'Total Revenue', 'Total Penalty', 'Daily Pass', 'Monthly Pass', 'Yearly Pass'],
            datasets: [{
                label: 'Statistics',
                data: [1, 1700.00, 500.00, 1, 1, 1],
                backgroundColor: [
                    'rgba(255, 99, 132, 0.2)',
                    'rgba(54, 162, 235, 0.2)',
                    'rgba(255, 206, 86, 0.2)',
                    'rgba(75, 192, 192, 0.2)',
                    'rgba(153, 102, 255, 0.2)',
                    'rgba(255, 159, 64, 0.2)'
                ],
                borderColor: [
                    'rgba(255, 99, 132, 1)',
                    'rgba(54, 162, 235, 1)',
                    'rgba(255, 206, 86, 1)',
                    'rgba(75, 192, 192, 1)',
                    'rgba(153, 102, 255, 1)',
                    'rgba(255, 159, 64, 1)'
                ],
                borderWidth: 1
            }]
        },
        options: {
            responsive: true,
            plugins: {
                legend: {
                    position: 'top',
                },
                title: {
                    display: true,
                    text: 'PMPML Dashboard Statistics'
                }
            }
        }
    });
}
