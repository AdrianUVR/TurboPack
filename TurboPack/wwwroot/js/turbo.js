
$(document).ready(function () { //click
    GetAll();
 
});

function GetAll() {
    $.ajax({
        type: 'GET',
        url: 'https://randomuser.me/api/',
        success: function (results) { //200 OK 
            $('#Table tbody');
         
                var filas =
                      "<tr>"+       
                      '<td><img id="Img" src="' + results.results[0].picture.medium + '" style="width:100px ; height:100px"/>' + '</td>'
                    + '<td  id="id" class="text - center">' + results.results[0].name.title + results.results[0].name.first + "</td>"
                    + '<td  id="id" class="text - center">' + results.results[0].gender + "</td>"
                    + '<td  id="id" class="text - center">' + results.results[0].email + "</td>"
                    + "<td class='text-center'>" + results.results[0].location.city + ',' + results.results[0].location.country +  "</td>"
                  
                    + "</tr>"; 
                $("#Table tbody").append(filas);
            
        },
        error: function (result) {
            alert('Error en la consulta.' + result.responseJSON.ErrorMessage);
        }
    });
};
