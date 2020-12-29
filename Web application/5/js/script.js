
$(() => {
    $('#upload').submit(upload);
    $('#gen_report').submit(getReport);
    $('#stop').click(cancelUpload);
    $('#gropubycheckbox').change(changeGroupPanel);
});

var timeout;

function changeGroupPanel(){
    if($('#gropubycheckbox').is(':checked')){
        $('#groupbyselect').html("<option value=\"DMON\">Days</option>\n" +
            "<option value=\"WYEAR\">Weeks</option>\n" +
            "<option value=\"MYEAR\">Months</option>");
    }else{
        $('#groupbyselect').html("<option value=\"id\">id</option>\n" +
            "<option value=\"ip\">ip</option>\n" +
            "<option value=\"date\">date</option>\n" +
            "<option value=\"path\">path</option>\n" +
            "<option value=\"method\">method</option>\n" +
            "<option value=\"response_code\">response code</option>\n" +
            "<option value=\"response_size\">response size</option>\n" +
            "<option value=\"user_agent\">user agent</option>");
    }
}

function upload(e) {
    e.preventDefault();
    const formData = new FormData(this);

    $.ajax({
        url: '/upload', 
        type: 'POST',
        data: formData, 
        processData: false,
        contentType: false,
        success: () => {
            hideLoadingUI(); 
            clearTimeout(timeout);
            alert('Данные загружены.');
            return true;
        }
    });

    showLoadingUI();
    timeout = setTimeout(updateStatus, 500);
}

function updateStatus() {
    $.get('/status', {}, (resp) => {
        var percent = +resp;
        setProgressBarVal(percent);
        if (percent > 99.9) {
            clearTimeout(timeout);
            hideLoadingUI();
        }
    });
    timeout = setTimeout(updateStatus, 500);
}

function cancelUpload() {
    clearTimeout(timeout);
    hideLoadingUI();
    $.get("/cancel", {}, () => {
        alert("Uploading canceled.");
    });
    timeout = setTimeout(cancelUploadData, 500);
}

function cancelUploadData() {
    clearTimeout(timeout);
    $.get("/update", {}, () => {
        return false;
    });
}

function getReport () {
    $.get('/report', $(this).serialize(), (data) => showReport(data));
    return false;
}

function showReport (data) {
    if($('#gropubycheckbox').is(':checked')){
        $('#report_table').html('<thead>\n' +
            '                    <tr>\n' +
            '                        <th scope="col">Количество</th>\n' +
            '                        <th scope="col">День в месяце</th>\n' +
            '                        <th scope="col">Неделя в году</th>\n' +
            '                        <th scope="col">Месяц в году</th>\n' +
            '                    </tr>\n' +
            '                    </thead>\n' +
            '                    <tbody id="table_body">\n' +
            '\n' +
            '\n' +
            '                    </tbody>');
        $.parseJSON(data).forEach(element => {
            $('#table_body').append(
                "<tr>\n" +
                "<th scope=\"row\">" + element.count + "</th>\n" +
                "<td>" + element.DMON + "</td>\n" +
                "<td>" + element.WYEAR + "</td>\n" +
                "<td>" + element.MYEAR + "</td>\n" +
                "</tr>"
            )
        })
    }else{
        $('#report_table').html('<thead>\n' +
            '                    <tr>\n' +
            '                        <th scope="col">ID</th>\n' +
            '                        <th scope="col">IP Адрес</th>\n' +
            '                        <th scope="col">Дата посещения</th>\n' +
            '                        <th class=\'path_class\' scope="col">Страница</th>\n' +
            '                        <th scope="col">Метод запроса</th>\n' +
            '                        <th scope="col">Код ответа</th>\n' +
            '                        <th scope="col">Размер ответа</th>\n' +
            '                        <th scope="col">Вход с</th>\n' +
            '                    </tr>\n' +
            '                    </thead>\n' +
            '                    <tbody id="table_body">\n' +
            '\n' +
            '\n' +
            '                    </tbody>');
        $.parseJSON(data).forEach(element => {
            $('#table_body').append(
                "<tr>\n" +
                "<th scope=\"row\">" + element.id + "</th>\n" +
                "<td>" + element.ip + "</td>\n" +
                "<td>" + element.date + "</td>\n" +
                "<td class='path_class'>" + element.path + "</td>\n" +
                "<td>" + element.method + "</td>\n" +
                "<td>" + element.response_code + "</td>\n" +
                "<td>" + element.response_size + "</td>\n" +
                "<td>" + element.user_agent + "</td>\n" +
                "</tr>"
            )
        })
    }

}


function setProgressBarVal(percent) {
    $('.progress-bar').css("width", percent + "%");
}

function showLoadingUI() {
    $('.upload-btn .spinner-border').show();
    $('.upload-btn').addClass('disabled');
    $('.stop-btn').show();
    $('.progress').show();
    $('.title_progress').show();
}

function hideLoadingUI() {
    $('.upload-btn .spinner-border').hide();
    $('.upload-btn').removeClass('disabled');
    $('.stop-btn').hide();
    $('.progress').hide();
    $('.title_progress').hide();
}
