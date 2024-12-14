document.getElementById('valid-btn').addEventListener('click', function() {
    alert("Valid");
});

document.getElementById('not-valid-btn').addEventListener('click', function() {
    alert("Not Valid");
});

document.getElementById('done-btn').addEventListener('click', function() {
    var penaltyAmount = document.getElementById('penalty').value;
    if (penaltyAmount) {
        alert("Penalty Submitted: " + penaltyAmount);
    } else {
        alert("Please enter a penalty amount.");
    }
});
