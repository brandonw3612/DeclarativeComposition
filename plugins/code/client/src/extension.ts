import * as path from 'path';
import * as vscode from 'vscode';
import {
  LanguageClient,
  LanguageClientOptions,
  ServerOptions,
  TransportKind
} from 'vscode-languageclient/node';

let client: LanguageClient;

export function activate(context: vscode.ExtensionContext) {
  const serverModule = context.asAbsolutePath(
    path.join('server', 'out', 'server.js')
  );

  const debugOptions = { execArgv: ['--nolazy', '--inspect=6009'] };

  const serverOptions: ServerOptions = {
    run: { module: serverModule, transport: TransportKind.ipc },
    debug: { module: serverModule, transport: TransportKind.ipc, options: debugOptions }
  };

  const clientOptions: LanguageClientOptions = {
    documentSelector: [{ language: 'dcl' }],
    outputChannelName: 'DCL Language Server',
    synchronize: {
      fileEvents: vscode.workspace.createFileSystemWatcher('**/*.{dc,dcl}')
    },
  };

  client = new LanguageClient(
    'dclLanguageServer',
    'DCL Language Server',
    serverOptions,
    clientOptions
  );

  client.start();
}

export function deactivate(): Thenable<void> | undefined {
  return client ? client.stop() : undefined;
}