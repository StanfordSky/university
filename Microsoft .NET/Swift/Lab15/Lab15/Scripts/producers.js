var apiBaseUrl = "https://localhost:44334/api/";
var producersUrl = apiBaseUrl + "Producers/";

function reloadProducerList() {
	var producersList = $("#ProducersList");
	if (producersList.length) { //Есть элемент для списка пользователей - значит мы на главной странице - можно загрузить список
		$.ajax({
			url: producersUrl,
			dataType: "json",
			data: null,
			type: "GET",
		
			success: function (data) {

		
				// Do something with the result
				var itemsCount = data.length;
				producersList.html("");
				var html = "<table>";
				for (var i = 0; i < itemsCount; i++) {
					var item = data[i];
					var userId = item.id;
					var fullName = item.FullName;
				
					html += "<tr><td>" +  fullName + "</td>";
					html += "<td><a href='edit.html?id=" + userId + "'>Редактировать</a>&nbsp;<a href='#' class='delete_producer' data-id='" + userId + "'>Удалить</a></td></tr>";
				}
				html += "</table>";
				producersList.html(html);

			},
			error: function (xmlHttpRequest, textStatus, errorThrown) {
				if (xmlHttpRequest.readyState == 0 || xmlHttpRequest.status == 0)
					return;  // it's not really an error
				else
					alert("get failed");
			}
		});

	}
	
}
$(document).ready(function () {
	reloadProducerList();


	var producersList = $("#ProducerInfo");
	if (producersList.length) { //Есть элемент для информации о пользователе -  загрузить информацию о нём
		var url_string = window.location.href;
		var url = new URL(url_string);
		var id = url.searchParams.get("id");
		if (id != null) {
			$.ajax({
				url: producersUrl + id + "/",
				dataType: "json",
				data: null,
				type: "GET",
				success: function (data) {
					var userId = data.id;
					var firstName = data.FirstName;
					var lastName = data.LastName;
					$("#LastName").val(lastName);
					$("#FirstName").val(firstName);

				}
			});
			producersList.after("<input type='button' id='EditProducer' value='Сохранить'/>");
		}
		else {
			producersList.after("<input type='button' id='CreateProducer' value='Создать'/>");
		}
	};


	$(document).on("click", ".delete_producer", function () {
		var id = $(this).attr("data-id");
		if (id != null) {
			$.ajax({
				url: producersUrl + id + "/",
				dataType: "json",
				data: null,
				type: "DELETE",
				success: function (data) {
					reloadUserList();
				}
			});
		}
	});

	$(document).on("click", "#CreateProducer", function () {
		var producerData = {
			LastName: $("#LastName").val(),
			FirstName: $("#FirstName").val(),
			
		};
		$.ajax({
			url: producersUrl,
			dataType: "json",
			data: producerData,
			type: "POST",
			success: function () {
				window.location.href = "../Producers/index.html";
			}
		});
	});

	$(document).on("click", "#EditProducer", function () {
		var url_string = window.location.href;
		var url = new URL(url_string);
		var id = url.searchParams.get("id");
		if (id != null) {
			var userData = {
				id: id,
				LastName: $("#LastName").val(),
				FirstName: $("#FirstName").val(),
				FullName: $("#FirstName").val()+" "+$("#LastName").val()
			
			};
			$.ajax({
				url: producersUrl + id + "/",
				dataType: "json",
				data: userData,
				type: "PUT",
				success: function () {
					window.location.href = "../Producers/index.html";
		
				},
				error: function () {
					alert("put failed");
                }
			});
		}
	});
})
