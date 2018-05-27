function Submit() {
	let validDiv = document.getElementById("valid_msg");
	let invalidDiv = document.getElementById("invalid_msg");

	if (!ValidateName() || !ValidateUsername() || !ValidatePassword() || !ValidateBirthday() 
		|| !ValidateGender() || !ValidatePhoneNumber() || !ValidateEmail() || !ValidatePicture()) {
		validDiv.style.display = "none";
		invalidDiv.style.display = "block";
	} else {
		validDiv.style.display = "block";
		invalidDiv.style.display = "none";
		document.getElementById("registration_form").reset();
	}
}

function ValidateName() {
	let regex = /^([\u0400-\u04FFA-Za-z]+)$/i;
	let firstName = document.getElementById("firstName");
	let lastName = document.getElementById("lastName");

	if (regex.exec(firstName.value) === null) {
		firstName.classList.add("invalid_input");
	} else {
		firstName.classList.remove("invalid_input");
	}

	if (regex.exec(lastName.value) === null) {
		lastName.classList.add("invalid_input");
	} else {
		lastName.classList.remove("invalid_input");
	}

	if (regex.exec(firstName.value) !== null && regex.exec(lastName.value) !== null) {
		return true;
	}

	return false;
}

function ValidateUsername() {
    let regex = /^(?=.{4,20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$/i;
    let username = document.getElementById("username");

	if (regex.exec(username.value) === null) {
		username.classList.add("invalid_input");
		return false;
	}

	username.classList.remove("invalid_input");
	return true;
}

function ValidatePassword() {
	let password = document.getElementById("password");
	let confirmedPassword = document.getElementById("confirmedPassword");

	if (password.value.length < 6 || password.value !== confirmedPassword.value) {
		password.classList.add("invalid_input");
		confirmedPassword.classList.add("invalid_input");
		return false;
	}

	password.classList.remove("invalid_input");
	confirmedPassword.classList.remove("invalid_input");
	return true;
}

function ValidateBirthday() {
	let birthday_input = document.getElementById("birthday");
	let birthday = Date.parse(birthday_input.value);

	if (birthday >= Date.now() || birthday == "" || isNaN(birthday)) {
		birthday_input.classList.add("invalid_input");
		return false;
	}

	birthday_input.classList.remove("invalid_input");
	return true;
}

function ValidateGender() {
	let gender = document.getElementById("gender");
	let selectedItem = gender.selectedIndex;

	if (selectedItem == 0) {
		gender.classList.add("invalid_input");
		return false;
	}

	gender.classList.remove("invalid_input");
	return true;
}

function ValidatePhoneNumber() {
	let regex = /^(?:\+359|0)(\s|\-)*\d{3}\1*(\s|\-)*\d{3}\1*(\s|\-)*\d{3}\1*$/i;
	let phoneNumber = document.getElementById("phoneNumber");

	if (regex.exec(phoneNumber.value) === null) {
		phoneNumber.classList.add("invalid_input");
		return false;
	}

	phoneNumber.classList.remove("invalid_input");
	return true;
}

function ValidateEmail() {
	let regex = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
	let email = document.getElementById("email");

	if (regex.exec(email.value) === null) {
		email.classList.add("invalid_input");
		return false;
	}

	email.classList.remove("invalid_input");
	return true;
}

function ValidatePicture() {
	let verificationText = document.getElementById("verificationText");

	if (verificationText.value !== "802") {
		verificationText.classList.add("invalid_input");
		return false;
	}

	verificationText.classList.remove("invalid_input");
	return true;
}
