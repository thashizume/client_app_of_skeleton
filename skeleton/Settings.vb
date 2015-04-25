
Namespace My
    
    'このクラスでは設定クラスでの特定のイベントを処理することができます:
    ' SettingChanging イベントは、設定値が変更される前に発生します。
    ' PropertyChanged イベントは、設定値が変更された後に発生します。
    ' SettingsLoaded イベントは、設定値が読み込まれた後に発生します。
    ' SettingsSaving イベントは、設定値が保存される前に発生します。
    Partial Friend NotInheritable Class MySettings

        Private Sub MySettings_PropertyChanged(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles Me.PropertyChanged

        End Sub

        Private Sub MySettings_SettingChanging(sender As Object, e As System.Configuration.SettingChangingEventArgs) Handles Me.SettingChanging

        End Sub

        Private Sub MySettings_SettingsLoaded(sender As Object, e As System.Configuration.SettingsLoadedEventArgs) Handles Me.SettingsLoaded

        End Sub

        Private Sub MySettings_SettingsSaving(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.SettingsSaving

        End Sub
    End Class
End Namespace
