document.getElementById('conductor-form').addEventListener('submit', function(event) {
    var prn = document.getElementById('prn').value.trim();
    var aadhaar = document.getElementById('aadhaar').value.trim();

    // Validation for empty fields
    if (!prn && !aadhaar) {
        alert('Please enter either PRN Number or Aadhaar Number.');
        event.preventDefault(); // Prevent form submission
    }

    // Validation for PRN (5 digits, only numbers)
    if (prn && (!/^\d{5}$/.test(prn))) {
        alert('PRN Number must be exactly 5 digits and only numbers are allowed.');
        event.preventDefault();
    }

    // Validation for Aadhaar (12 digits, only numbers)
    if (aadhaar && (!/^\d{12}$/.test(aadhaar))) {
        alert('Aadhaar Number must be exactly 12 digits and only numbers are allowed.');
        event.preventDefault();
    }
});
