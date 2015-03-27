<?xml version="1.0" encoding="utf-8"?>
<configurationSectionModel xmlns:dm0="http://schemas.microsoft.com/VisualStudio/2008/DslTools/Core" dslVersion="1.0.0.0" Id="cfbe46af-9934-48d5-a68f-c7cfe64da053" namespace="MirrorConfiguration" xmlSchemaNamespace="urn:MirrorConfiguration" xmlns="http://schemas.microsoft.com/dsltools/ConfigurationSectionDesigner">
  <typeDefinitions>
    <externalType name="String" namespace="System" />
    <externalType name="Boolean" namespace="System" />
    <externalType name="Int32" namespace="System" />
    <externalType name="Int64" namespace="System" />
    <externalType name="Single" namespace="System" />
    <externalType name="Double" namespace="System" />
    <externalType name="DateTime" namespace="System" />
    <externalType name="TimeSpan" namespace="System" />
  </typeDefinitions>
  <configurationElements>
    <configurationSection name="MirrorConfiguration" namespace="SpaceTraffic.GithubToTfsSync" codeGenOptions="Singleton, XmlnsProperty" xmlSectionName="mirrorConfiguration">
      <elementProperties>
        <elementProperty name="SourceRepository" isRequired="true" isKey="false" isDefaultCollection="false" xmlName="sourceRepository" isReadOnly="false">
          <type>
            <configurationElementMoniker name="/cfbe46af-9934-48d5-a68f-c7cfe64da053/SourceRepository" />
          </type>
        </elementProperty>
        <elementProperty name="TargetRepositories" isRequired="true" isKey="false" isDefaultCollection="false" xmlName="targetRepositories" isReadOnly="false">
          <type>
            <configurationElementCollectionMoniker name="/cfbe46af-9934-48d5-a68f-c7cfe64da053/TargetRepositoryCollection" />
          </type>
        </elementProperty>
      </elementProperties>
    </configurationSection>
    <configurationElement name="TargetRepository" namespace="SpaceTraffic.GithubToTfsSync">
      <attributeProperties>
        <attributeProperty name="Id" isRequired="true" isKey="true" isDefaultCollection="false" xmlName="id" isReadOnly="false" documentation="Unique identifier of the repository entry." defaultValue="&quot;_&quot;">
          <validator>
            <regexStringValidatorMoniker name="/cfbe46af-9934-48d5-a68f-c7cfe64da053/RepositoryIdValidator" />
          </validator>
          <type>
            <externalTypeMoniker name="/cfbe46af-9934-48d5-a68f-c7cfe64da053/String" />
          </type>
        </attributeProperty>
        <attributeProperty name="Url" isRequired="true" isKey="false" isDefaultCollection="false" xmlName="url" isReadOnly="false" documentation="URL of the target repository.">
          <type>
            <externalTypeMoniker name="/cfbe46af-9934-48d5-a68f-c7cfe64da053/String" />
          </type>
        </attributeProperty>
      </attributeProperties>
    </configurationElement>
    <configurationElementCollection name="TargetRepositoryCollection" namespace="SpaceTraffic.GithubToTfsSync" xmlItemName="repository" codeGenOptions="Indexer, AddMethod, RemoveMethod, GetItemMethods">
      <itemType>
        <configurationElementMoniker name="/cfbe46af-9934-48d5-a68f-c7cfe64da053/TargetRepository" />
      </itemType>
    </configurationElementCollection>
    <configurationElement name="SourceRepository" namespace="SpaceTraffic.GithubToTfsSync">
      <attributeProperties>
        <attributeProperty name="Url" isRequired="true" isKey="false" isDefaultCollection="false" xmlName="url" isReadOnly="false" documentation="URL of the source repository.">
          <type>
            <externalTypeMoniker name="/cfbe46af-9934-48d5-a68f-c7cfe64da053/String" />
          </type>
        </attributeProperty>
      </attributeProperties>
    </configurationElement>
  </configurationElements>
  <propertyValidators>
    <validators>
      <regexStringValidator name="RepositoryIdValidator" regularExpression="[A-Za-z0-9_]+" />
    </validators>
  </propertyValidators>
</configurationSectionModel>