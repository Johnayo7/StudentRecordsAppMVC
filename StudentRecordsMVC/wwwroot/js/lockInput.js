function toggleLock(inputId, lockButtonId) {
    var input = document.getElementById(inputId);
    var button = document.getElementById(lockButtonId);

    if (input.hasAttribute('readonly')) {
        input.removeAttribute('readonly');
        input.setAttribute('required', true);
        button.textContent = '🔓';
    } else {
        input.setAttribute('readonly', true);
        input.removeAttribute('required');
        button.textContent = '🔒';
    }
}

/*function toggleLock() {
    var input = document.getElementById('nameInput');
    var button = document.getElementById('lockButton');

    if (input.readOnly) {
        input.readOnly = false;
        button.textContent = '🔓';
    } else {
        input.readOnly = true;
        button.textContent = '🔒';
    }
}*/