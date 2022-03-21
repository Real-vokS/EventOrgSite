$(document).ready(function () {
    var i = 1;
    $("#addrow").click(function () {
        $('#ContentPlaceHolder1_tablogic').append('<tr id="addr' + (i + 1) + '"></tr>');
        $('#addr' + (i + 1)).html("<td class='text-center'>" + (i + 1) + "</td><td><input id='addr" + i + "_name' name='name" + i + "' type='text' placeholder='Name' class='form-control input-md'  /> </td><td><input id='addr" + i + "_amount' name='amount" + i + "' type='number' placeholder='Amount' min='0' step='1' class='form-control input-md'></td>");

        i++;
    });
    $("#deleterow").click(function () {
        if (i > 1) {
            $("#addr" + (i)).html('');
            i--;
        }
    });

});