$(document).ready(function () {
    $('#meuform').validate({
        rules: {
            "cliente.pessoa.Nome": {
                required: true
            },
            "cliente.pessoa.DataNascimento": {
                required: true
            },
            "cliente.pessoa.Rg": {
                required: true

            },
            "cliente.pessoa.Cpf": {
                required: true
            },
            "cliente.pessoa.Genero": {
                required: true

            },
            "cliente.pessoa.EstadoCivil": {
                required: true

            },
            "cliente.pessoa.Email": {
                required: true,
                Email: true

            },
            "cliente.pessoa.Fone": {
                required: true

            },
            "cliente.pessoa.Fone2": {
                required: true

            },
            "cliente.pessoa.endereco.Rua": {
                required: true
            
            },
            "cliente.pessoa.endereco.Bairro": {
                required: true

            },
            "cliente.pessoa.endereco.numero": {
                required: true

            },
            "cliente.pessoa.endereco.Complemento": {
                required: true

            },
            "cliente.pessoa.endereco.Cidade": {
                required: true

            },
            "cliente.pessoa.endereco.Estado": {
                required: true

            },
            "cliente.pessoa.endereco.Cep": {
                required: true
            },
            "cliente.NomeUsuario": {
                required: true
            },
            "cliente.Senha": {
                required: true
            },
            repetindoSenha: {
                required: true,
                equalTo: "#senhaSistema"
            }
        },

        messages: {
            "cliente.pessoa.Nome": {
                required: "Este campo é obrigatório."
            },
            "cliente.pessoa.DataNascimento": {
                required: "Este campo é obrigatório."
            },
            "cliente.pessoa.Rg": {
                required: "Este campo é obrigatório."
            },
            "cliente.pessoa.Cpf": {
                required: "Este campo é obrigatório."

            },
            "cliente.pessoa.Genero": {
                required: "Este campo é obrigatório."

            },
            "cliente.pessoa.EstadoCivil": {
                required: "Este campo é obrigatório."

            },
            "cliente.pessoa.Email": {
                required: "Este campo é obrigatório."

            },
            "cliente.pessoa.Fone": {
                required: "Este campo é obrigatório."

            },
            "cliente.pessoa.Fone2": {
                required: "Este campo é obrigatório."

            },
            "cliente.pessoa.endereco.Rua": {
                required: "Este campo é obrigatório."

            },
            "cliente.pessoa.endereco.Bairro": {
                required: "Este campo é obrigatório."

            },
            "cliente.pessoa.endereco.numero": {
                required: "Este campo é obrigatório."

            },
            "cliente.pessoa.endereco.Complemento": {
                required: "Este campo é obrigatório."

            },
            "cliente.pessoa.endereco.Cidade": {
                required: "Este campo é obrigatório."

            },
            "cliente.pessoa.endereco.Estado": {
                required: "Este campo é obrigatório."

            },
            "cliente.pessoa.endereco.Cep": {
                required: "Este campo é obrigatório."


            },
            "cliente.NomeUsuario": {
                required: "Este campo é obrigatório"
            },
            "cliente.Senha": {
                required: "Este campo é obrigatório."
            },
            repetindoSenha: {
                required: "Este campo é obrigatório.",
                equalTo: "#senhaSistema"
            }
        },
        
    });
});

//function validarCPF(cpf) {
//    cpf = cpf.replace(/[^\d]+/g, '');
//    if (cpf == '') return false;
//    // Elimina CPFs invalidos conhecidos	
//    if (cpf.length != 11 ||
//        cpf == "00000000000" ||
//        cpf == "11111111111" ||
//        cpf == "22222222222" ||
//        cpf == "33333333333" ||
//        cpf == "44444444444" ||
//        cpf == "55555555555" ||
//        cpf == "66666666666" ||
//        cpf == "77777777777" ||
//        cpf == "88888888888" ||
//        cpf == "99999999999")
//        return false;
//    // Valida 1o digito	
//    add = 0;
//    for (i = 0; i < 9; i++)
//        add += parseInt(cpf.charAt(i)) * (10 - i);
//    rev = 11 - (add % 11);
//    if (rev == 10 || rev == 11)
//        rev = 0;
//    if (rev != parseInt(cpf.charAt(9)))
//        return false;
//    // Valida 2o digito	
//    add = 0;
//    for (i = 0; i < 10; i++)
//        add += parseInt(cpf.charAt(i)) * (11 - i);
//    rev = 11 - (add % 11);
//    if (rev == 10 || rev == 11)
//        rev = 0;
//    if (rev != parseInt(cpf.charAt(10)))
//        return false;
//    return true;
//}

$("#fone").mask("(00) 00000-0000"); // Máscara para CELULAR 
$("#fone2").mask("(00) 0000-0000");  // Máscara para TELEFONE
$("#cep").mask("00000-000");    // Máscara para CEP
$("#nasc").mask("00/00/0000");  // Máscara para DATA
$("#cpf").mask("000.000.000-00");
$("#rg").mask("0000000000");