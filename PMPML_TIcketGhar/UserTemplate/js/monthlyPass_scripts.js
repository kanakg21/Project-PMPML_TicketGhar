// scripts.js
document.getElementById('pass-form').addEventListener('submit', function(e) {
    e.preventDefault();
    
    let name = document.getElementById('name').value;
    let mobile = document.getElementById('mobile').value;
    let aadhar = document.getElementById('aadhar').value;
    let gender = document.getElementById('gender').value;
    let docCode = document.getElementById('doc-code').value;
    
    // Sample verification logic
    if (docCode === '12345') {
        alert('Form submitted successfully!');
    } else {
        alert('Invalid Document Verification Code!');
    }
});
