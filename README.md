# Minecraft-discord-bot-app

# これは何
DisocordからMinecraftのサーバーを起動させることが可能になるアプリです。

# 初回セットアップ

setting.jsonを開いて以下の値を環境に合わせて編集してください

CommandAddはDisocordにコマンド登録するときに使います。

二回目以降はfalseに設定してください
```
"Port": マインクラフトサーバーのポートアドレス,

"Path": マインクラフトサーバー実行ファイルのパス"例C:\\Users\\username\\Desktop\\Minecraft Server\\Start.bat",

"Key": DisocordBotのKey,

"ServerKey": DisocordサーバーID,

"CommandAdd": true,
```

# 使い方
ローカルサーバーと同じ環境にアプリを導入します。

実行ファイルを起動するとDisocordBotがオンラインになります。

Disocordから/Startを実行するとマインクラフトサーバーが起動します。
