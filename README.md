# Minecraft-discord-bot-app

# これは何
DisocordからMinecraftのサーバーを起動させることが可能にするアプリです。

# 初回セットアップ

setting.jsonを開いて以下の値を環境に合わせて編集してください

CommandAddはDisocordにコマンド登録するときに使います。

次回起動する時はfalseに設定してください
```
"Port": マインクラフトサーバーのポートアドレス,

"Path": マインクラフトサーバー実行ファイルのパス"C:\\Users\\yuppy\\Desktop\\Custum Minecraft Server\\Start.bat",

"Key": DisocordBotのKey,

"ServerKey": サーバーID,

"CommandAdd": true,
```

# 使い方
ローカルサーバーと同じ環境にアプリを導入します。

実行ファイルを起動するとDisocordBotがオンラインになります。

Disocordから/Startを実行するとマインクラフトサーバーが起動します。
