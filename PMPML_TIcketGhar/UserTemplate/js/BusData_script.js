const mobileNumberInput = document.getElementById('mobile-number');
const payNowButton = document.getElementById('pay-now');
const radioButtons = document.querySelectorAll('input[name="bus"]');

mobileNumberInput.addEventListener('input', function () {
    validateForm();
});

radioButtons.forEach(radio => {
    radio.addEventListener('change', function () {
        validateForm();
    });
});

function validateForm() {
    const mobileNumber = mobileNumberInput.value.trim();
    const isRadioChecked = document.querySelector('input[name="bus"]:checked') !== null;

    if (isRadioChecked && /^\d{10}$/.test(mobileNumber)) {
        payNowButton.disabled = false;
    } else {
        payNowButton.disabled = true;
    }
}
