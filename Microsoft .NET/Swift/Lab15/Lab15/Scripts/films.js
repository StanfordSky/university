var apiBaseUrl = "https://localhost:44334/api/";
var filmsUrl = apiBaseUrl + "Films/";

function LoadFilms(data, filmsList) {


	// Do something with the result
	var itemsCount = data.length;
	filmsList.html("");
	var html = "<table>";

	html += "<thead><tr>";
	html += "		<th scope='col'>Название</th>";
	html += "		<th scope='col'>Год</th>";
	html += "		<th scope='col'>Режисер</th>";
	html += "		<th scope='col'>Постер</th>";

	html += "	</tr></thead>";
	html += "<tbody>";
	for (var i = 0; i < itemsCount; i++) {
		var item = data[i];
		var filmId = item.id;
		var Title = item.Title;
		var Year = item.year;
		var cover = item.cover;
		if (item.Producer1 != null)
			var Producer = item.Producer1.FullName;
		else
			var Producer = "null";

		
		html += "<tr>";
		html += "<td>" + Title + "</td>";
		html += "<td>" + Year + "</td>";
		html += "<td>" + Producer + "</td>";
		html += "<td>" + "<img id='ItemPreview' src='data:image/png;base64,"+cover+"'>"+ "</td>";
		html += "<td><a href='edit.html?id=" + filmId + "'>Редактировать</a>&nbsp;<a href='#' class='delete_film' data-id='" + filmId + "'>Удалить</a></td></tr>";
	}
	html += "</tbody>";
	html += "</table>";
	filmsList.html(html);
}


function LoadFilm(data, filminfo) {

	var item = data;
	var filmId = item.id;
	var Title = item.Title;
	var Year = item.year;
	var cover = item.cover;
	var ProducerId = item.producer;

	$("#Title").val(Title);
	$("#Year").val(Year);
	//$("#SelectProducer").val(ProducerId);
	document.getElementById("SelectProducer").value = ProducerId;
	$("#coverImg").prop("src", "data:image/png;base64,"+cover);
}

function reloadFilmsList() {
	var filmsList = $("#FilmsList");
	if (filmsList.length) { //Есть элемент для списка пользователей - значит мы на главной странице - можно загрузить список
		$.ajax({
			url: filmsUrl,
			dataType: "json",
			data: null,
			type: "GET",

			success: function (data) {
			
				LoadFilms(data, filmsList);
			},
			error: function (xhr, status, error) {
				
				var errorMessage = xhr.status + ': ' + xhr.statusText
				alert('Error - ' + errorMessage);
			}
		});

	}
		
}

function loadFilmInfo(){
	var filminfo = $("#FilmInfo");
	if (filminfo.length) { //Есть элемент для информации о пользователе -  загрузить информацию о нём
		var url_string = window.location.href;
		var url = new URL(url_string);
		var id = url.searchParams.get("id");
		if (id != null) {
			$.ajax({
				url: filmsUrl + id + "/",
				dataType: "json",
				data: null,
				type: "GET",
				success: function (data, filminfo) {
					LoadFilm(data);
				}
			});
			filminfo.after("<input type='button' id='EditFilm' value='Сохранить'/>");
		}
		else {	
			$("#Year").val(2020);
			filminfo.after("<input type='button' id='CreateFilm' value='Создать'/>");
		}
	};
}
function LoadSelectOptions() {

	var select = $("#SelectProducer");
	if (select != null) {


		
		$.ajax({
			url: apiBaseUrl + "Producers/",
			dataType: "json",
			data: null,
			type: "GET",

			success: function (data) {
			
				for (var i = 0; i < data.length; i++) {

					jQuery('<option/>', {
						value: data[i].id,
						html: data[i].FullName
					}).appendTo('#SelectProducer'); //appends to select if parent div has id dropdown

				}
			},
			error: function (xhr, status, error) {
				var errorMessage = xhr.status + ': ' + xhr.statusText
				alert('Error - ' + errorMessage);
			}
		});

	}
}

$(document).ready(function () {
	LoadSelectOptions();
	reloadFilmsList();
	loadFilmInfo();

	$(document).on("click", ".delete_film", function () {
		var id = $(this).attr("data-id");
		if (id != null) {
			$.ajax({
				url: filmsUrl + id + "/",
				dataType: "json",
				data: null,
				type: "DELETE",
				success: function (data) {
					reloadFilmsList();
				}
			});
		}
	});
	var fileinput = document.getElementById('fileinput');
	if (fileinput != null) {
		function handleFileSelect(evt) {
			var f = evt.target.files[0]; // FileList object
			if (f == undefined) return;
			// Loop through the FileList and render image files as thumbnails.


			var reader = new FileReader();

			// Closure to capture the file information.
			reader.onload = (function (theFile) {
				return function (e) {
					// Render thumbnail.

					$("#coverImg").prop("src", e.target.result);

				};
			})(f);

			// Read in the image file as a data URL.
			reader.readAsDataURL(f);
		}
		fileinput.addEventListener('change', handleFileSelect, false);

		var evt = document.createEvent("HTMLEvents");
		evt.initEvent("change", false, true);
		fileinput.dispatchEvent(evt);
	}

	function readFile(file, onLoadCallback) {
		var reader = new FileReader();
		reader.onload = onLoadCallback;
		reader.readAsDataURL(file);

	}


	$(document).on("click", "#CreateFilm", function () {

		var files = $("#fileinput").prop("files");
		var f = files[0];
		readFile(f, function (e) {
			
			//var coverUint8 = new Uint8Array(e.target.result);		
			//var cover = btoa(coverUint8);
			
			var cover = e.target.result;
			cover = cover.replace('data:image/jpeg;base64,', '');
		
			var producer_Id = $("#SelectProducer").val();
			if (producer_Id == undefined) {
				alert("Режисер не был выбран!");
			}
			else {
				var filmData = {
					Title: $("#Title").val(),
					year: $("#Year").val(),
					producer: producer_Id,
					cover: cover
				};
				console.log(filmData.cover);


				var url = filmsUrl;
				var method = "POST";
				$.ajax({
					url, method,

					data: JSON.stringify(filmData),
					contentType: 'application/json',
					success: function () {
					

						window.location.href = "../Films/index.html";


					},
					error: function (xhr, status, error) {
						alert("put failed");

					}
				});
				
			}
		});

	});

	




	$(document).on("click", "#EditFilm", function () {
		
		var files = $("#fileinput").prop("files");
		var f = files[0];

		readFile(f, function (e) {
	

			//var coverUint8 = new Uint8Array(e.target.result);
			//var cover = btoa(coverUint8);
			
			var cover = e.target.result;
			//cover = cover.replace('\n,', '');
			cover = cover.replace('data:image/jpeg;base64,', '');	
		
		
			var producer_Id = $("#SelectProducer").val();
			if (!producer_Id ) {
				alert("Режисер не был выбран!");
			}
			else {
				var url_string = window.location.href;
				var url = new URL(url_string);
				var id = url.searchParams.get("id");
				if (id != null) {

					var filmData = {
						id:id,
						Title: $("#Title").val(),
						year: $("#Year").val(),
						producerId: producer_Id,
						cover: cover
					};
					var url = filmsUrl + id + "/";
					var method = "PUT";
					$.ajax({
						url, method,
						
						data: JSON.stringify(filmData),
						contentType: 'application/json',
						success: function () {
					
							window.location.href = "../Films/index.html";


						},
						error: function (xhr, status, error) {
							alert("put failed");

						}
					});
				}
			}
		});

		
		
	});

})