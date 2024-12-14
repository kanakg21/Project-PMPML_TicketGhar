document.getElementById('pdf-upload-form').addEventListener('submit', function(event) {
    event.preventDefault(); // Prevent form submission
    var fileInput = document.getElementById('pdf-upload');
    if (fileInput.files.length > 0) {
        alert("PDF uploaded successfully!");
    } else {
        alert("Please select a PDF file to upload.");
    }
});
