select dbo.��������_���������.�����_��������,dbo.��������.���,count(dbo.������.���_������)
from dbo.�������� INNER JOin
dbo.��������_��������� on dbo.��������.���_�������� = dbo.��������_���������.���_�������� inner join
dbo.������ on dbo.������.���_������ = dbo.��������_���������.���_��������
GROUP BY dbo.��������_���������.�����_��������,dbo.��������.���,dbo.������.���_������