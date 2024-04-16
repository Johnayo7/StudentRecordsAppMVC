// deleteConfirmation.js

function confirmDelete(deleteUrl) {
    if (confirm("Are you sure you want to delete this?")) {
        const matNo = getMatNoFromUrl();

        var form = document.createElement('form');
        form.method = 'post';
        form.action = deleteUrl;

        var hiddenField = document.createElement('input');
        hiddenField.type = 'hidden';
        hiddenField.name = 'matNo';
        hiddenField.value = matNo;

        form.appendChild(hiddenField);
        document.body.appendChild(form);
        form.submit();
    }
}

function getMatNoFromUrl() {
    const urlParams = new URLSearchParams(window.location.search);
    return urlParams.get('matNo');
}

/*// deleteConfirmation.js
function confirmDelete() {
    if (confirm("Are you sure you want to delete this?")) {
        const matNo = getMatNoFromUrl();
        fetch(`/Student/Delete?matNo=${matNo}`, {
            method: 'DELETE'
        }).then(response => {
            if (response.ok) {
                window.location.href = '/Student';
            } else {
                alert('Failed to delete the record.');
            }
        }).catch(error => {
            console.error('Error deleting record:', error);
            alert('An error occurred while deleting the record.');
        });
    }
}

function getMatNoFromUrl() {
    const urlParams = new URLSearchParams(window.location.search);
    return urlParams.get('matNo');
}*/