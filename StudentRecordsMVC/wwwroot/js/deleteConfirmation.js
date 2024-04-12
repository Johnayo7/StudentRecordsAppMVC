// deleteConfirmation.js

function confirmDelete(deleteUrl) {
    if (confirm("Are you sure you want to delete this?")) {
        // If user confirms, continue with the deletion process
        window.location.href = deleteUrl;
    }
}