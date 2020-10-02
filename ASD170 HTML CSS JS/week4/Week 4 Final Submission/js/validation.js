const requiredFields = document.querySelectorAll("input[required]");

requiredFields.forEach(field => {
    field.addEventListener('keyup', function (event) {
        isValid = field.checkValidity();
        if (isValid) field.id = "";
            else field.id = "invalid-input";
    });
})