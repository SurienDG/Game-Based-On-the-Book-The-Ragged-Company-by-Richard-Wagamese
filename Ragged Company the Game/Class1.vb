'Animates a form when it is shown, hidden or closed.

Public NotInheritable Class FormAnimator
    Dim rs As Resizer
    'The types of animation available.
    Public Enum AnimationTypes
        Roll = &H0      'Roll out from edge to show; Roll in to edge to hide.  Requires direction.  Default animation.
        Centre = &H10   'Expand out from centre to show; Collapse in to centre to hide.
        Slide = &H40000 'Slide out from edge to show; Slide in to edge to hide.  Requires direction.
        Blend = &H80000 'Blend from transaprent to opaque to show; Blend from opaque to transparent to hide.
    End Enum

    'The directions in which the Slide animation can be shown.
    'The Flags attribute indicates that directions can be combined.
    <Flags()> Public Enum SlideDirections
        None = 0
        Right = &H1 'Slide from left to right.
        Left = &H2  'Slide from right to left.
        Down = &H4  'Slide from top to bottom.
        Up = &H8    'Slide from bottom to top.
    End Enum

    Private Const AW_HIDE As Integer = &H10000      'Hide the form.
    Private Const AW_ACTIVATE As Integer = &H20000  'Activate the form.

    Private WithEvents m_Form As Form               'The form to be animated.

    Private m_Type As AnimationTypes                'The type of animation used to show and hide the form.
    Private m_Direction As SlideDirections          'The direction in which to Roll or Slide the form.
    Private m_Duration As Integer = 500             'The number of milliseconds over which the animation is played.

    'The type of animation used to show and hide the form.
    Public Property AnimationType() As AnimationTypes
        Get
            Return Me.m_Type
        End Get
        Set(ByVal Value As AnimationTypes)
            Me.m_Type = Value
        End Set
    End Property

    'The direction in which to Roll or Slide the form.
    Public Property SlideDirection() As SlideDirections
        Get
            Return Me.m_Direction
        End Get
        Set(ByVal Value As SlideDirections)
            Me.m_Direction = Value
        End Set
    End Property

    'The number of milliseconds over which the animation is played.
    Public Property AnimationDuration() As Integer
        Get
            Return Me.m_Duration
        End Get
        Set(ByVal Value As Integer)
            Me.m_Duration = Value
        End Set
    End Property

    'Windows API function used to animate the form.
    Private Declare Auto Function AnimateWindow Lib "user32" (ByVal hwnd As IntPtr, _
                                                              ByVal dwtime As Integer, _
                                                              ByVal dwflags As Integer) As Boolean

    'Creates a new FormAnimator object for the specified form.
    Public Sub New(ByVal form As Form)
        
        Me.m_Form = form
    End Sub

    'Creates a new FormAnimator object for the specified form using the specified animation type over the specified duration.
    Public Sub New(ByVal form As Form, _
                   ByVal type As AnimationTypes, _
                   ByVal duration As Integer)
        Me.New(form)

        Me.m_Type = type
        Me.m_Duration = duration
    End Sub

    'Creates a new FormAnimator object for the specified form using the specified animation type in the specified
    'direction over the specified duration.  This is intended to be used with Roll and Slide animations.
    Public Sub New(ByVal form As Form, _
                   ByVal type As AnimationTypes, _
                   ByVal direction As SlideDirections, _
                   ByVal duration As Integer)
        Me.New(form, type, duration)

        Me.m_Direction = direction
    End Sub

    'Animates the form automatically when it is shown or hidden.
    Private Sub m_Form_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles m_Form.VisibleChanged
        Dim flags As Integer = Me.m_Type Or Me.m_Direction

        If Me.m_Form.Visible Then
            'Activate the form.

            flags = flags Or Me.AW_ACTIVATE
        Else
            'Hide the form.
            flags = flags Or Me.AW_HIDE
        End If

        Me.AnimateWindow(Me.m_Form.Handle, _
                         Me.m_Duration, _
                         flags)
    End Sub

    'Animates the form automatically when it closes.
    Private Sub m_Form_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles m_Form.Closing
        'Hide the form.
        Me.AnimateWindow(Me.m_Form.Handle, _
                         Me.m_Duration, _
                         Me.AW_HIDE Or Me.m_Type Or Me.m_Direction)
    End Sub

End Class