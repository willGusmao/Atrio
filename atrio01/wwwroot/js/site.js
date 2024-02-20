// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


//  Tela INDEX  APOS LOGIN 

document.addEventListener('DOMContentLoaded', function () {
    const menuPrincipal = document.querySelector('.MenuPrincipal');
    const conteudo = document.querySelector('.HomeDivA');


    menuPrincipal.addEventListener('mouseenter', function () {
        conteudo.style.transition = 'margin-left 0.5s';  // Desativa a transição temporariamente
        conteudo.style.marginLeft = '12%';
    });

    menuPrincipal.addEventListener('mouseleave', function () {
        conteudo.style.transition = 'margin-left 0.2s';  // Reativa a transição
        conteudo.style.marginLeft = '1%';
    });
});
// TELA  LISTA DE PACIENTES 

document.addEventListener('DOMContentLoaded', function () {
    const menuPrincipal = document.querySelector('.MenuPrincipal');
    const conteudo = document.querySelector('.ListaPacientes');


    menuPrincipal.addEventListener('mouseenter', function () {
        conteudo.style.transition = 'margin-left 0.5s';  // Desativa a transição temporariamente
        conteudo.style.marginLeft = '12%';
    });

    menuPrincipal.addEventListener('mouseleave', function () {
        conteudo.style.transition = 'margin-left 0.2s';  // Reativa a transição
        conteudo.style.marginLeft = '1%';
    });
});

// TELA DE CADASTRO DE PACIENTES

document.addEventListener('DOMContentLoaded', function () {
    const menuPrincipal = document.querySelector('.MenuPrincipal');
    const conteudo = document.querySelector('.TelaCadastroPai');


    menuPrincipal.addEventListener('mouseenter', function () {
        conteudo.style.transition = 'margin-left 0.5s';  // Desativa a transição temporariamente
        conteudo.style.marginLeft = '12%';
    });

    menuPrincipal.addEventListener('mouseleave', function () {
        conteudo.style.transition = 'margin-left 0.2s';  // Reativa a transição
        conteudo.style.marginLeft = '1%';
    });
});

// VIEW PACIENTE

document.addEventListener('DOMContentLoaded', function () {
    const menuPrincipal = document.querySelector('.MenuPrincipal');
    const conteudo = document.querySelector('.DivPaiPaciente');


    menuPrincipal.addEventListener('mouseenter', function () {
        conteudo.style.transition = 'margin-left 0.5s';  // Desativa a transição temporariamente
        conteudo.style.marginLeft = '12%';
    });

    menuPrincipal.addEventListener('mouseleave', function () {
        conteudo.style.transition = 'margin-left 0.2s';  // Reativa a transição
        conteudo.style.marginLeft = '1%';
    });
});