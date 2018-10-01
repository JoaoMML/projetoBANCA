  $(document).ready(function () {
            var tabela = $('#tabela').DataTable({
                dom: 'Blftip',
                select: { style: 'single'},
                "ajax": {
                    "url": "/Cliente/ListaClientes",
                    "type": "GET",
                    "datatype": "json",
                },
                "columns": [
                    { "data": "Id", "autoWidth": true, },
                    { "data": "Pessoa.Nome", "autoWidth": true },
                    { "data": "Pontos", "autoWidth": true },

                ]
            });

            // Inativa CLiente no banco de dados e da DataTable
            $('#excluir').click(function () {
                var clienteId = tabela.rows({ selected: true }).data()[0].Id;
                $.ajax({
                    type: "GET",
                    url: "/Cliente/InativaCliente/" + clienteId,
                    dataType: "json",
                    success: function (response) {
                        if (response.inativou) {
                            alert("Cliente apagado!");
                            tabela.ajax.reload();
                        }
                    }
                });
            });

            // envia id para controler
            $('#editar').click(function () {
                var ClienteId = tabela.rows({ selected: true }).data()[0].Id;
                window.location.href = "/Cliente/UpdateForm/" + ClienteId
            });
 });