$(function(){
    // Cuando el usuario presione el boton, se generara la tabla de multiplicar
    $('#generar').on('click', function(){
        // Numero de la tabla
        var numero = parseInt($('#cantidad').val());

        // Validar que el usuario digite un numero mayor a 0
        if (numero <= 0) {
            alert('Debe ingresar un valor mayor que 0');
            $('#tabla_multi').html('');
            return;
        }

        var html = '';
        for(var i=1; i<=12; i++) {
            html += `<tr>
                    <td>${numero}</td>
                    <td>*</td>
                    <td>${i}</td>
                    <td>=</td>
                    <td>${numero * i}</td>
                    </tr>`;
        }

        $('#tabla_multi').html(html);

    })
});