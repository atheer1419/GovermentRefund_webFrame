var survey_options = document.getElementById('survey_options');
var add_more_fields = document.getElementById('add_more_fields');
var remove_fields = document.getElementById('remove_fields');
//document.getElementsByName('TKT[]');


add_more_fields.onclick = function () {
	var newField = document.createElement('input');
	newField.setAttribute('type', 'text');
	newField.setAttribute('name', 'TKT[]');
	newField.setAttribute('class', 'survey_options');
	newField.setAttribute('siz', 50);
	newField.setAttribute('placeholder', 'Another Field');
	survey_options.appendChild(newField);
	listControl.add()
}

remove_fields.onclick = function () {
	var input_tags = survey_options.getElementsByTagName('input');
	if (input_tags.length > 2) {
		survey_options.removeChild(input_tags[(input_tags.length) - 1]);
	}
}


//pop up message 

document.getElementById("open-popup-btn").addEventListener("click", function () {
	document.getElementsByClassName("popup")[0].classList.add("active");
});

document.getElementById("dismiss-popup-btn").addEventListener("click", function () {
	document.getElementsByClassName("popup")[0].classList.remove("active");
});

