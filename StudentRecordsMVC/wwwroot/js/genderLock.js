//genderLock.js
function toggleGenderLock() {
    var maleInput = document.getElementById('male');
    var femaleInput = document.getElementById('female');
    var button = document.getElementById('genderLockButton');
    var genderHidden = document.getElementById('genderHidden');

    // Check if the male input is disabled (indicating that the gender is locked)
    if (maleInput.hasAttribute('disabled')) {

        // Enable male and female inputs
        maleInput.removeAttribute('disabled');
        femaleInput.removeAttribute('disabled');
        button.textContent = '🔓'; // Change button text to indicate unlock
    }
    else {

        // Disable male and female inputs
        maleInput.setAttribute('disabled', true);
        femaleInput.setAttribute('disabled', true);
        button.textContent = '🔒'; // Change button text to indicate lock

        // Set the value of the hidden gender field based on the selected radio button
        if (maleInput.checked) {
            genderHidden.value = 'Male';
        }
        else if (femaleInput.checked) {
            genderHidden.value = 'Female';
        }
        else {
            genderHidden.value = ''; // No option selected
        }
    }
}

