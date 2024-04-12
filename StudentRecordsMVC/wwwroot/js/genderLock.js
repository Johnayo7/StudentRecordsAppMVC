function toggleGenderLock() {
    var maleInput = document.getElementById('male');
    var femaleInput = document.getElementById('female');
    var button = document.getElementById('genderLockButton');

    if (maleInput.hasAttribute('disabled')) {
        maleInput.removeAttribute('disabled');
        femaleInput.removeAttribute('disabled');
        button.textContent = '🔓';
    } else {
        maleInput.setAttribute('disabled', true);
        femaleInput.setAttribute('disabled', true);
        button.textContent = '🔒';
    }
}