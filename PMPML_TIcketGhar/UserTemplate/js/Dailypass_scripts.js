// scripts.js
document.getElementById('pass-form').addEventListener('submit', function(e) {
    e.preventDefault();
    
    let name = document.getElementById('name').value;
    let mobile = document.getElementById('mobile').value;
    let aadhar = document.getElementById('aadhar').value;
    let gender = document.getElementById('gender').value;
    
    // Simple alert to confirm form submission
    alert(`Form submitted successfully! \nName: ${name} \nMobile: ${mobile} \nAadhar: ${aadhar} \nGender: ${gender}`);
});
