$(document).ready(function () {
    $('#meuform').validate({
        rules: {
            "funcionario.pessoa.Nome": {
                required: true
            },
            "funcionario.pessoa.DataNascimento": {
                required: true
            },
            "funcionario.pessoa.Rg": {
                required: true

            },
            "funcionario.pessoa.Cpf": {
                required: true
            },
            "funcionario.pessoa.Genero": {
                required: true

            },
            "funcionario.pessoa.EstadoCivil": {
                required: true

            },
            "funcionario.pessoa.Email": {
                required: true,
                Email: true

            },
            "funcionario.pessoa.Fone": {
                required: true

            },
            "funcionario.pessoa.Fone2": {
                required: true

            },
            "funcionario.pessoa.endereco.Rua": {
                required: true
            
            },
            "funcionario.pessoa.endereco.Bairro": {
                required: true

            },
            "funcionario.pessoa.endereco.numero": {
                required: true

            },
            "funcionario.pessoa.endereco.Complemento": {
                required: true

            },
            "funcionario.pessoa.endereco.Cidade": {
                required: true

            },
            "funcionario.pessoa.endereco.Estado": {
                required: true

            },
            "funcionario.pessoa.endereco.Cep": {
                required: true
            },
            "funcionario.NomeDeUsuario": {
                required: true
            },
            "funcionario.funcionario.TipoDeAcesso": {
                required: true
            },
            "funcionario.Cargo": {
                required: true
            },
            "funcionario.Senha": {
                required: true
            },
            repetindoASenha: {
                required: true,
                equalTo: "#senhaSistema"
            }
        },

        messages: {
            "funcionario.pessoa.Nome": {
                required: "Este campo é obrigatório."
            },
            "funcionario.pessoa.DataNascimento": {
                required: "Este campo é obrigatório."
            },
            "funcionario.pessoa.Rg": {
                required: "Este campo é obrigatório."
            },
            "funcionario.pessoa.Cpf": {
                required: "Este campo é obrigatório."

            },
            "funcionario.pessoa.Genero": {
                required: "Este campo é obrigatório."

            },
            "funcionario.pessoa.EstadoCivil": {
                required: "Este campo é obrigatório."

            },
            "funcionario.pessoa.Email": {
                required: "Este campo é obrigatório."

            },
            "funcionario.pessoa.Fone": {
                required: "Este campo é obrigatório."

            },
            "funcionario.pessoa.Fone2": {
                required: "Este campo é obrigatório."

            },
            "funcionario.pessoa.endereco.Rua": {
                required: "Este campo é obrigatório."

            },
            "funcionario.pessoa.endereco.Bairro": {
                required: "Este campo é obrigatório."

            },
            "funcionario.pessoa.endereco.numero": {
                required: "Este campo é obrigatório."

            },
            "funcionario.pessoa.endereco.Complemento": {
                required: "Este campo é obrigatório."

            },
            "funcionario.pessoa.endereco.Cidade": {
                required: "Este campo é obrigatório."

            },
            "funcionario.pessoa.endereco.Estado": {
                required: "Este campo é obrigatório."

            },
            "funcionario.pessoa.endereco.Cep": {
                required: "Este campo é obrigatório."


            },
            "funcionario.NomeDeUsuario": {
                required: "Este campo é obrigatório."
            },
            "funcionario.funcionario.TipoDeAcesso": {
                required: "Este campo é obrigatório."
            },
            "funcionario.Cargo": {
                required: "Este campo é obrigatório."
            },
            "funcionario.Senha": {
                required: "Este campo é obrigatório."
            },
            repetindoASenha: {
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