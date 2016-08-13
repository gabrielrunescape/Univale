/**
  * A variável modal é responsável por exibir o título do Alert
  * A variável body é responsável por exibir o corpo da mensagem
  * A variavél salve é do tipo boolean se exibe ou não o botão de salvar
*/
function alertBootStrap(var modal, var body, var salve) {
  document.write('<div class="modal fade" tabindex="-1" role="dialog">');
  document.writeln('  <div class="modal fade" tabindex="-1" role="dialog">');
  document.writeln('    <div class="modal-dialog" role="document">');
  document.writeln('      <div class="modal-content">');
  document.writeln('        <div class="modal-header">');
  document.writeln('          <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>');
  document.writeln('          <h4 class="modal-title">' + modal + '</h4>');
  document.writeln('        </div>');
  document.writeln('        <div class="modal-body">');
  document.writeln('          <p>' + body +'</p>');
  document.writeln('        </div>');
  document.writeln('        <div class="modal-footer">');
  document.writeln('          <button type="button" class="btn btn-default" data-dismiss="modal">Fechar</button>');

  if (salve == true || salve == 1) {
    document.writeln('<button type="button" class="btn btn-primary">Salvar mudanças</button>');
  }

  document.writeln('        </div>\n      </div><!-- /.modal-content -->\n    </div><!-- /.modal-dialog -->\n </div><!-- /.modal -->');
}
