// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var FormObjects = [];
FormObjects[0] = [];
FormObjects[1] = [];



function loadSlider()
{
    $.ajax({
        type: "GET",
        url: "/Photos/Load",
        dataType: "json",
        success: function (data)
        {
            $('.gallery-top').html("");
            $('.gallery-thumbs').html("");
            $('.gallery-top').append("<div class='swiper-wrapper' id='gal'></div>");
            $('.gallery-thumbs').append("<div class='swiper-wrapper' id='thumb'></div>");
            $.each(data, function (key, value)
            {
                $('#gal').append("<div class='swiper-slide' style='text-align:center;'><img height='400' src='" + value.imageUrl + "'/><br/>" + value.caption + "</div>");
                $('#thumb').append("<div class='swiper-slide'><img height='100' src='" + value.imageUrl + "'/></div>");
            });
            $('.gallery-top').append("<div class='swiper-button-next swiper-button-white'></div>");
            $('.gallery-top').append("<div class='swiper-button-prev swiper-button-white'></div>");

            var galleryThumbs = new Swiper('.gallery-thumbs', {
                spaceBetween: 10,
                slidesPerView: 6,
                freeMode: true,
                watchSlidesVisibility: true,
                watchSlidesProgress: true,
            });
            var galleryTop = new Swiper('.gallery-top', {
                spaceBetween: 10,
                centeredSlides: true,
                pagination: {
                    el: '.swiper-pagination',
                    clickable: true,
                },
                navigation: {
                    nextEl: '.swiper-button-next',
                    prevEl: '.swiper-button-prev',
                },
                thumbs: {
                    swiper: galleryThumbs,
                },
            });
        }
    })
}

function AjaxPost(formdata)
{
    var form_Data = new FormData(formdata);

    for (var i = 0, file; file, file = FormObjects[0][i]; i++)
    {
        form_Data.append('files[]', file);
        form_Data.delete('Files')
    }

    for (var j = 0, caption; caption = FormObjects[1][j]; j++)
    {
        form_Data.append('ImageCaption[]', caption);
        form_Data.delete('ImageCaption');
    }

    var AjaxOptions =
    {
        type: "POST",
        url: "Photos/Add/",
        data: form_Data,
        success: function (result)
        {
            alert(result);
            window.location.href="/Photos"
        }
    }

    if ($(formdata).attr('enctype') == "multipart/form-data")
    {
        AjaxOptions['contentType'] = false;
        AjaxOptions['processData'] = false;
    }

    $.ajax(AjaxOptions)
    return false
}

function PreviewFiles()
{

    var files = document.querySelector('input[type=file]').files;
    function readAndPreview(file)
    {
        if (/\.(jp?eg|png|gif)$/i.test(file.name))
        {
        }
        var reader = new FileReader();
        reader.addEventListener("load", function () {
            var image = new Image(200, 200);
            image.title = file.name;
            image.border = 2;
            image.src = this.result;
            addImageRow(image);
            countTableRow();
            FormObjects[0].push(file);
        }, false);
        reader.readAsDataURL(file);
       
        
    }

    if (files && files[0]) {
        [].forEach.call(files, readAndPreview);
    }
    $('input[type=file]').val(null);
}

function removeFile(item)
{
    var row = $(item).closest('tr');

    if ($("#previewTable tbody tr").length > 1) {
        FormObjects[0].splice(row.index(), 1);
        FormObjects[1].splice(row.index(), 1);
        row.remove();
        countTableRow();
    }
    else if ($("#previewTable tbody tr").length == 1)
    {
        $("#previewTable tbody").remove();
        FormObjects[0] = [];
        FormObjects[1] = [];
        countTableRow();
    }
}

function clearPreview()
{
    if ($("#previewTable tbody").length > 0)
    {
        $("#previewTable tbody").remove();
        $("#imgCount").html("<i class='fa fa-images'></i>");
    }
}

function countTableRow()
{
    $("#imgCount").html("<i class='fa fa-images'></i>" + $("#previewTable tbody tr").length);
}

function addImageRow(image)
{
    if ($("#previewTable tbody").length == 0)
    {
        $("#previewTable").append("<tbody></tbody>");
    }
    $("#previewTable tbody").append(BuildImageTableRow(image));
}


function delPreviewRow(item)
{
    var filename = $(item).closest('[name="photo[]"]');
}


function BuildImageTableRow(image)
{
    var newRow = "<tr>" +
        "<td>" +
        "<div class=''>" +
        "<img name='photo[]' style='border:1px solid' width='100' height='50'class='image-tag' src='" + image.src + "' /> " +
        "</div>" +
        "</td>" +
        "<td>" +
        "<div class=''>" +
        "<input name='ImageCaption[]' class='form-control col-xs-3' value='' placeholder='Введите описание'>" +
        "</div>" +
        "</td>" +
        "<td>" +
        "<div class='btn-group' role='group' aria-label='Perform Actions'>" +
        "<button type='button' name='Delete' class='btn btn-danger btn-sm' onclick='removeFile(this)'>" +
        "<span>" +
        "<i class='fa fa-trash'></i>" +
        "</span>" +
        "</button>" +
        "</div>" +
        "</td>" +
        "</tr>";
    return newRow;
}

var VidForm = [];
VidForm[0] = [];
VidForm[1] = [];
VidForm[2] = [];

function PostVids(formdata) {
    var form_Data = new FormData(formdata);

    for (var i = 0, file; file, file = VidForm[0][i]; i++)
    {
        form_Data.append('files[]', file);
        form_Data.delete('Files')
    }

    for (var j = 0, caption; caption = VidForm[1][j]; j++)
    {
        form_Data.append('VideoCaption[]', caption);
        form_Data.delete('VideoCaption');
    }

    for (var k = 0, vidname; vidname = VidForm[2][k]; k++)
    {
        form_Data.append('VideoName[]', vidname);
        form_Data.delete('VideoName');
    }

    var AjaxOptions =
    {
        type: "POST",
        url: "Videos/Add",
        data: form_Data,
        success: function (result) {
            alert(result);
            window.location.href = "/Videos"
        }
    }

    if ($(formdata).attr('enctype') == "multipart/form-data") {
        AjaxOptions['contentType'] = false;
        AjaxOptions['processData'] = false;
    }

    $.ajax(AjaxOptions)
    return false
}


function PreviewVids() {

    var files = document.querySelector('input[type=file]').files;
    function readAndPreview(file) {
        var reader = new FileReader();
        reader.addEventListener("load", function () {
            var video = new Object();
            video.title = file.name;
            video.src = this.result;
            addVideoRow(video);
            countVids();
            VidForm[0].push(file);
        }, false);
        reader.readAsDataURL(file);
    }

    if (files && files[0]) {
        [].forEach.call(files, readAndPreview);
    }
    $('input[type=file]').val(null);
}



function removeVid(item) {
    var row = $(item).closest('tr');

    if ($("#previewTable tbody tr").length > 1) {
        VidForm[0].splice(row.index(), 1);
        VidForm[1].splice(row.index(), 1);
        VidForm[2].splice(row.index(), 1);
        row.remove();
        countVids();
    }
    else if ($("#previewTable tbody tr").length == 1) {
        $("#previewTable tbody").remove();
        VidForm[0] = [];
        VidForm[1] = [];
        VidForm[2] = [];
        countVids();
    }
}

function clearVids() {
    if ($("#previewTable tbody").length > 0) {
        $("#previewTable tbody").remove();
        $("#imgCount").html("<i class='fa fa-video'></i>");
    }
}

function countVids() {
    if ($("#previewTable tbody tr").length == 0) {
        $("#imgCount").html("<i class='fa fa-video'></i> ");
    }
    else
    {
        $("#imgCount").html("<i class='fa fa-video'></i> " + $("#previewTable tbody tr").length);
    }
}

function addVideoRow(video) {
    if ($("#previewTable tbody").length == 0) {
        $("#previewTable").append("<tbody></tbody>");
    }
    $("#previewTable tbody").append(BuildVideoTableRow(video));
}


function delPreviewRow(item) {
    var filename = $(item).closest('[name="photo[]"]');
}


function BuildVideoTableRow(image) {
    var newRow = "<tr>" +
        "<td>" +
        "<div class=''>" +
        "<input name='VideoName[]' class='form-control col-xs-3' value='' placeholder='Введите название'>" +
        "</div>" +
        "</td>" +
        "<td>" +
        "<div class=''>" +
        "<textarea name='VideoCaption[]' class='form-control col-xs-3' value='' placeholder='Введите описание' style='resize: none;'></textarea>" +
        "</div>" +
        "</td>" +
        "<td>" +
        "<div class='btn-group' role='group' aria-label='Perform Actions'>" +
        "<button type='button' name='Delete' class='btn btn-danger btn-sm' onclick='removeVid(this)'>" +
        "<span>" +
        "<i class='fa fa-trash'></i>" +
        "</span>" +
        "</button>" +
        "</div>" +
        "</td>" +
        "</tr>";
    return newRow;
}

function loadVideos() {
    $.ajax({
        type: "GET",
        url: "/Videos/Load",
        dataType: "json",
        success: function (data) {
            $('.vidList').html("");
            $.each(data, function (key, value) {
                $('.vidList').append("<div class='thumbCont' id='" + value.id +
                    "' onclick='playVideo(this)'><img src='" + value.thumbUrl +
                    "' height='100' style='padding-top:5px;'></img><br/>" + value.name + "</div>");
            });
        }
    })
}

function playVideo(item) {
    $.ajax({
        type: "GET",
        url: "Videos/Load/" + item.id,
        dataType: "json",
        success: function (result) {
            $('.vidPlayer').html("");
            $('.vidPlayer').append("<div class='vid' ><video src='" + result.videoUrl + "' controls style='width:600px'></video></div>");
            $('.vidPlayer').append("<div class='vidname'><h2>" + result.name + "</h2></div>");
            $('.vidPlayer').append("<div class='vidcaption'><p>" + result.caption + "</p></div>");
        }
    });
}