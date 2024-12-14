function validateForm() {
    const name = document.getElementById('name').value.trim();
    const mobile = document.getElementById('mobile').value.trim();
    const aadhar = document.getElementById('aadhar').value.trim();
    const email = document.getElementById('email').value.trim();
    const verificationCode = document.getElementById('verificationCode').value.trim();

    // Name validation: only letters and spaces allowed
    if (!/^[a-zA-Z\s]+$/.test(name)) {
        alert("Name can only contain letters and spaces.");
        return false;
    }

    // Mobile validation: only numbers allowed, length 10 digits
    if (!/^\d{10}$/.test(mobile)) {
        alert("Mobile number must be 10 digits long.");
        return false;
    }

    // Aadhar validation: only numbers allowed, length 12 digits
    if (!/^\d{12}$/.test(aadhar)) {
        alert("Aadhar number must be 12 digits long.");
        return false;
    }

    // Email validation: already handled by input type="email"

    // Document Verification Code validation: alphanumeric only
    if (!/^[a-zA-Z0-9]+$/.test(verificationCode)) {
        alert("Document Verification Code can only contain letters and numbers.");
        return false;
    }

    return true;
}
